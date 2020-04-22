using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Webserver.Data.ViewModel
{
    public class DeviceViewStandard
    {
        public long Id { get; set; }
        public long RoomMessageId { get; set; }
        public long UserId { get; set; }
        public string MacAddress { get; set; }
        public int SignalStrength { get; set; }
    }

    public class DeviceViewNoRoom
    {
        public string MacAddress { get; set; }
        public int SignalStrength { get; set; }
    }
}
