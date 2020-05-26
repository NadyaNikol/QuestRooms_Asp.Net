using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApplication4.EF;
using WebApplication4.Models;

namespace WebApplication4.Repositories
{

    public abstract class CustomRepository<T> : IRepository<T> where T :class, IEntity
    {
        protected abstract DbSet<T> collection { get; set; }
        protected DbContext db;
        //public int Count => db.Rooms.Count();

        //public int Count => localList.Count;
        //private List<QuestRoom> localList;
        //        delete[] lib

        //int* arr=(int*)malloc(length*sizeof(int))

        public CustomRepository() { }

        public CustomRepository(DbContext context, DbSet<T> collection)
        {
            db = context;
            this.collection = collection;
            //localList = new List<QuestRoom>();
        }

        //public CustomRepository(List<QuestRoom> list)
        //{
        //    localList = list;
        //}

        public virtual T Add(T item)
        {
            //db.Entry(item).State = System.Data.Entity.EntityState.Added;
            //db.SaveChanges();
            //localList.Add(item);
            collection.Add(item);
            return item;
        }

        public virtual List<T> GetAll()
        {
            return collection.ToList<T>();
            //return localList.ToList();
        }

        public virtual T GetById(int id)
        {          
            return collection.FirstOrDefault(i => i.Id == id);
           // return localList.FirstOrDefault(i => i.Id == id);
        }

        public virtual T Update(T item)
        {
            db.Set<T>().AddOrUpdate(item);
            //collection.Entry(item).State = System.Data.Entity.EntityState.Modified;
            ////db.Entry(item.Telephones.Where(e=>e.QuestRoomId==item.Id)).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            return item;
            //int ind = localList.FindIndex(i => i.Id==item.Id);
            //this.localList[ind] = item;
            //return item;
        }

        public virtual T Delete(int id)
        {
            var room = collection.FirstOrDefault(q => q.Id == id);
            if (room != null)
                Delete(room);
            return room;
            //QuestRoom room = new QuestRoom { Id = id };
            //db.Entry(room).State = System.Data.Entity.EntityState.Deleted;
            //db.SaveChanges();
            // localList.Remove(localList.Find(i => i.Id == id));
        }

        public T Delete(T item)
        {
            collection.Remove(item);

            return item;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}