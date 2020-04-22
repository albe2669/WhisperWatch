using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Webserver.Data.ViewModel
{
    public class RoomViewStandard
    {
        public long Id { get; set; }
        public long FloorId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public long Area { get; set; }
    }

    public class RoomViewNoFloor
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public long Area { get; set; }
    }
}
