using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Login.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Login.Application.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario?> GetByIdAsync(int id);
        void Add(Usuario entity);
        Task SaveAsync();
    }
}