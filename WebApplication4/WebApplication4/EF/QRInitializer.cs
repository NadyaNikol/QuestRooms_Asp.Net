using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.EF
{
    public class QRInitializer: DropCreateDatabaseAlways<QRContext>
    {
        protected override void Seed(QRContext context)
        {
          
            IList<QuestRoom> rooms = new List<QuestRoom>();


            context.Rooms.Add(new QuestRoom()
            {
                Id = 1,
                Adress = "aaa",
                Company = "qqq",
                Description = "ddd",
                Email = "ff@gmail.ua",
                LavelOfFear = 11,
                LevelOfDifficulty = 15,
                Logo = "vlovushke.jpg",
                MaxPlayers = 25,
                MinPlayers = 2,
                Name = "nname",
                Rating = 100,
                Time = "22:02",
                Telephones = new List<Telephone>()
                { new Telephone{Number = "802345675" },
                new Telephone { Number = "0984527475" }}
            });

            context.Rooms.Add(new QuestRoom()
            {
                Id = 2,
                Adress = "bbb",
                Company = "ccc",
                Description = "sss",
                Email = "faaa@gmail.ua",
                LavelOfFear = 9,
                LevelOfDifficulty = 25,
                Logo = "cropped.jpg",
                MaxPlayers = 43,
                MinPlayers = 4,
                Name = "nnamffkfle",
                Rating = 150,
                Time = "11:02",
                //Number = "0485743893"
                Telephones = new List<Telephone>()
                { new Telephone{Number = "8093534546" },
                new Telephone { Number = "803567567" },
                new Telephone {Number = "893678978" } }
            }
            );

            //IList<Telephone> telephones = new List<Telephone>();

            //telephones.Add(new Telephone { Number = "0982748534", QuestRoomId = 1 });
            //telephones.Add(new Telephone { Number = "0997462547", QuestRoomId = 1 });
            //telephones.Add(new Telephone { Number = "0639576544", QuestRoomId = 2 });
            //telephones.Add(new Telephone { Number = "0507774433", QuestRoomId = 2 });

            //context.Telephones.AddRange(telephones);
            context.SaveChanges();
           // base.Seed(context);
        }
    }
}