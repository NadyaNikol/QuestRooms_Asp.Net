using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Utils;

namespace WebApplication4.Repositories
{
    public class QuestRoomRepository: CustomRepository<QuestRoom>
    {
        protected override DbSet<QuestRoom> collection { get; set; }

        public QuestRoomRepository()
        {
        }

        public QuestRoomRepository(DbContext context, DbSet<QuestRoom> collection) : base(context, collection)
        {
        }

        public override QuestRoom Delete(int id)
        {
            var room = collection.FirstOrDefault(q => q.Id == id);
            var phoneRepo = DependencyResolver.Current.GetService<IUnitOfWork>();

            for (int i = 0; i < room.Telephones.Count; i++)
            {
                phoneRepo.Telephones.Delete((room.Telephones.ToList())[i]);
            }

            phoneRepo.Save();

            return base.Delete(id);
        }
    }
}