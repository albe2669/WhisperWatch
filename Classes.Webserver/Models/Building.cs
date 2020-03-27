using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Webserver.Models
{
    public class Building
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LastUpdated { get; set; }

        public string Secret { get; set; }

        public ICollection<Floor> Floors { get; set; }

    }

    public class BuildingContext : DbContext
    {
        public BuildingContext(DbContextOptions<BuildingContext> options) : base(options)
        {

        }

        public DbSet<Building> Buildings { get; set; }
    }
}
