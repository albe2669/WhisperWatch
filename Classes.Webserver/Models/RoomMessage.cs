using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Classes.Webserver.Models
{
    public class RoomMessage
    {
        public long Id { get; set; }

        [Required]
        public string PublisherId { get; set; }

        [Required]
        public long RoomId { get; set; }

        [Required]
        public long Clients { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }

        [JsonIgnore]
        public Room Room { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}
