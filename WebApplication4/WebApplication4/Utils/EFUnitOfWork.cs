using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.EF;
using WebApplication4.Models;
using WebApplication4.Repositories;

namespace WebApplication4.Utils
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public QRContext context { get; set; } = new QRContext();

        private IRepository<QuestRoom> questRooms;

        public IRepository<QuestRoom> QuestRooms
        {
            get
            {
                if (questRooms == null)
                    questRooms = new QuestRoomRepository(context, context.Rooms);
                return questRooms;
            }
            private set { }
        }

        private IRepository<Telephone> telephones;

        public IRepository<Telephone> Telephones
        {
            get
            {
                if (telephones == null)
                    telephones = new TelephoneRepository(context, context.Telephones);
                return telephones;
            }
            private set { }
        }


        public void Save()
        {
            context.SaveChanges();
        }
    }
}