using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Webserver.Models
{
    public class Message
    {
        public long Id { get; set; }
        
        [Required]
        public string Topic { get; set; }
        
        [Required]
        public string Body { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }

    }
}
