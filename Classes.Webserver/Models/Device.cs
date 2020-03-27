using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Webserver.Models
{
    public class Device
    {
        public long Id { get; set; }

        [Required]
        public long RoomMessageId { get; set; }

        [Required]
        public string MacAdress { get; set; }

        [Required]
        public int SignalStrength { get; set; }

        public long UserId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }

        public RoomMessage RoomMessage { get; set; }

        //public User User { get; set; }
    }
}
