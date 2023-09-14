using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApiContext context;
        private UserRepo _users;
        private RolRepo _roles;
        public UnitOfWork(ApiContext _context)
        {
            context = _context;
        }
       public IRol Rols
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepo(context);
                }
                return _roles;
            }
        }

    public IUser Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepo(context);
            }
            return _users;
        }
    }
        public void Dispose()
        {
            context.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
    