using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Webserver.Data.ViewModel
{
    public class DeviceViewStandard
    {
        public long Id { get; set; }
        public string MacAddress { get; set; }
        public int SignalStrength { get; set; }
    }
}
