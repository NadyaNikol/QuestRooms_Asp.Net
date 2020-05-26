using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.EF;
using WebApplication4.Models;
using WebApplication4.Repositories;

namespace WebApplication4.Utils
{
    public interface IUnitOfWork
    {
        QRContext context { get; }
        IRepository<QuestRoom> QuestRooms { get; }
        IRepository<Telephone> Telephones { get; }
        void Save();
    }
}
