using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.EF
{
    public class QRContext: DbContext
    {
        public QRContext() : base("QRContextString")
        {
           //Database.SetInitializer<QRContext>(new QRInitializer());
           //Database.Initialize(true);
        }

        public DbSet<QuestRoom> Rooms { get; set; }
        public DbSet<Telephone> Telephones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new QRInitializer());
        }
    }
}