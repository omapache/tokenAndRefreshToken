using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IUser : IGenericRepo<User>
    {
        Task<User> GetByUsernameAsync(String username);
        Task<User> GetByRefreshTokenAsync(String username);
    }
