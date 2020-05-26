using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.EF;
using WebApplication4.Models;

namespace WebApplication4.Repositories
{
    public class TelephoneRepository : CustomRepository<Telephone>
    {
        public TelephoneRepository() { }

        public TelephoneRepository(DbContext context, DbSet<Telephone> collection) : base(context, collection) { }

        protected override DbSet<Telephone> collection { get; set; }
    }
}