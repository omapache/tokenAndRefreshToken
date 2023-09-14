
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class RolRepo : GenericRepo<Rol>, IRol
    {
         private readonly ApiContext _context;

    public RolRepo(ApiContext context) : base(context)
    {
       _context = context;
    }
    }
}