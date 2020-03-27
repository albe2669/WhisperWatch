using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

using Classes.Webserver.Models;
using Microsoft.EntityFrameworkCore;

namespace Classes.Webserver.Data.SchoolContext
{
    public static class SchoolContextDbInitializer
    {
        private static void addBuildings(SchoolContext context)
        {
            Building[] buildings = new Building[]
            {
                new Building{Address="Stæhr Johansens Vej 7. 2000 Frederiksberg", Name="SJV 7"},
            };

            foreach (Building b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();
        }

        private static void addFloors(SchoolContext context)
        {
            Floor[] floors = new Floor[]
            {
                new Floor{BuildingId=1, Name="0 STUE", Description="", Level=0},
                new Floor{BuildingId=1, Name="1 SAL", Description="", Level=1},
                new Floor{BuildingId=1, Name="2 SAL", Description="", Level=2},
                new Floor{BuildingId=1, Name="3 SAL", Description="", Level=3},
                new Floor{BuildingId=1, Name="4 SAL", Description="", Level=4},
                new Floor{BuildingId=1, Name="5 SAL", Description="", Level=5},
                new Floor{BuildingId=1, Name="6 SAL", Description="", Level=6},
                new Floor{BuildingId=1, Name="7 SAL", Description="", Level=7},
            };

            foreach (Floor f in floors)
            {
                context.Floors.Add(f);
            }
            context.SaveChanges();
        }

        private static void addRooms(SchoolContext context)
        {
            Room[] rooms = (new RoomInitializeData()).Rooms;

            foreach (Room r in rooms)
            {
                context.Rooms.Add(r);
            }
            context.SaveChanges();
        }

        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Buildings.Any())
            {
                return; // DB already has data so do nothing.
            }

            addBuildings(context);
            addFloors(context);
            addRooms(context);

            context.SaveChanges();
            
        }
    }
}
