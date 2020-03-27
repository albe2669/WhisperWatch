using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Webserver.Models
{
    public class Floor
    {
        public long Id { get; set; }
        
        [Required]
        public long BuildingId { get; set; }
        
        [Required]
        public long Level { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Secret { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public Building Building { get; set; }
    }
}
