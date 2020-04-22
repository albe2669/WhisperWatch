using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Webserver.Data.ViewModel
{
    public class BuildingViewStandard
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class BuildingViewStandardWithFloors
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<FloorViewNoBuilding> Floors { get; set; }
    }
}
