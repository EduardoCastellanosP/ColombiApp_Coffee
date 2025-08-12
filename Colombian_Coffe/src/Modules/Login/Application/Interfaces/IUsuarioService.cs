using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Login.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Login.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task RegistrarUsuarioAsync(string nombre, string clave);
        Task<IEnumerable<Usuario>> ConsultarUsuariosAsync();
        Task<Usuario?> ObtenerUsuarioPorIdAsync(int id);
    }
}