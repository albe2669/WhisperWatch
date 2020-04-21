from time import sleep
from datetime import datetime as dt
from scapy.all import AsyncSniffer
import pandas as pd
import paho.mqtt.publish as publish
import configparser

config = configparser.ConfigParser()
config.read('conf.ini')

def startup():
    publish.single(
        config['MQTT']['CLIENT_TOPIC'], 
        'Client logging in with id: {} and roomid: {}'.format(
            config['MQTT']['CLIENT_ID'], 
            config['APP']['ROOM_ID']
        ), 
        hostname=config['MQTT']['HOST']
    )
    
def log(message):
    f = open(config['APP']['LOG_FILE'], 'a')
    f.write('[{}] {}\n'.format(dt.now().strftime('%d-%m-%Y %H:%M:%S'), message))
    f.close()

def sniff():
    sniffer = AsyncSniffer(filter=config['SNIFFER']['FILTER'], iface=config['SNIFFER']['ADAPTER'])

    log('Starting sniffer')
    sniffer.start()

    log('Sleeping')
    sleep(int(config['SNIFFER']['SLEEP_TIME']))

    log('Stopping sniffer')
    res = sniffer.stop()
    log('Stopped sniffer')
    log('Captured {} packets'.format(len(res)))

    return res

def parse(packets):
    objects = []
    for packet in packets:
        objects.append([
            packet.payload.addr2,
            packet.dBm_AntSignal,
            packet.dBm_AntNoise
        ])

    df = pd.DataFrame(objects, columns=['mac', 'signal_power', 'signal_noise'])
    return df.groupby('mac').mean()

if (config.getboolean('APP', 'SEND')):
    log('Sending startup message')
    startup()

log('Beginning main loop')
while True:
    log('Loop')
    df = parse(sniff())
    
    log('Creating payload')
    payload = '{{"client_id": "{}","room_id": {},"client_count": {}, "clients" : ['.format(config['MQTT']['CLIENT_ID'], config['APP']['ROOM_ID'], len(df.index))
    for index, row in df.iterrows():
        payload += '{{"signal_strength": {}, "mac_address": "{}"}},'.format(row['signal_power'], index)
    payload += ']}'

    if (config.getboolean('APP', 'SEND')):
        log('Publishing')
        publish.single(config['MQTT']['MESSAGE_TOPIC'], payload, hostname=config['MQTT']['HOST'])
        log('Published successfully')
    else:
        f = open(config['APP']['OUT_FILE'], 'a')
        f.write(payload + '\n')
        f.close()

    log('\n')
# 30:74:96:e2:25:01