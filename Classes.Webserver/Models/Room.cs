using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Webserver.Models
{
    public class Room
    {
        public long Id { get; set; }

        [Required]
        public long FloorId { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Name { get; set; }

        public long Area { get; set; }

        public string Secret { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }

        public ICollection<RoomMessage> RoomMessages { get; set; }

        public Floor Floor { get; set; }
    }
}
