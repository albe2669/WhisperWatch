using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Webserver.Data.ViewModel
{
    public class FloorViewStandard
    {
        public long Id { get; set; }
        public long BuildingId { get; set; }
        public long Level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class FloorViewNoBuilding
    {
        public long Id { get; set; }
        public long Level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
