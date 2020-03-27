using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.Extensions.DependencyInjection;
using Classes.Webserver.Models;

namespace Classes.Webserver.Data.SchoolContext
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomMessage> RoomMessages { get; set; }

        public DbSet<Device> Devices { get; set; }

        private static void addBuildings(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>().HasData(
                new Building{Id=1, Address="Stæhr Johansens Vej 7. 2000 Frederiksberg", Name="SJV 7"}
            );
        }

        private static void addFloors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Floor>().HasData(
                new Floor{Id=1, BuildingId=1, Name="0 STUE", Description="", Level=0},
                new Floor{Id=2, BuildingId=1, Name="1 SAL", Description="", Level=1},
                new Floor{Id=3, BuildingId=1, Name="2 SAL", Description="", Level=2},
                new Floor{Id=4, BuildingId=1, Name="3 SAL", Description="", Level=3},
                new Floor{Id=5, BuildingId=1, Name="4 SAL", Description="", Level=4},
                new Floor{Id=6, BuildingId=1, Name="5 SAL", Description="", Level=5},
                new Floor{Id=7, BuildingId=1, Name="6 SAL", Description="", Level=6},
                new Floor{Id=8, BuildingId=1, Name="7 SAL", Description="", Level=7}
            );
        }

        private static void addRooms(ModelBuilder modelBuilder)
        {
            Room[] rooms = (new RoomInitializeData()).Rooms;

            modelBuilder.Entity<Room>().HasData(rooms);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>().ToTable("Buildings");
            modelBuilder.Entity<Floor>().ToTable("Floors");
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<RoomMessage>().ToTable("RoomMessages");
            modelBuilder.Entity<Device>().ToTable("Devices");

            addBuildings(modelBuilder);
            addFloors(modelBuilder);
            addRooms(modelBuilder);
        }
    }


}
