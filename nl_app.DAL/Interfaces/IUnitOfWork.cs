using nl_app.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nl_app.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Phone> Phones { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
