using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Login.Application.Interfaces;
using Colombian_Coffe.src.Modules.Login.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Login.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repo;
        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<Usuario>> ConsultarUsuariosAsync()
        {
            return await _repo.GetAllAsync();
        }
        public async Task<Usuario?> ObtenerUsuarioPorIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
        public async Task RegistrarUsuarioAsync(string nombre, string clave)
        {
            var existentes = await _repo.GetAllAsync();

            if (existentes.Any(u => u.Nombre == nombre))
                throw new Exception("El equipo ya existe.");

            var usuario = new Usuario
            {
                Nombre = nombre,
                Clave = clave
            };

            _repo.Add(usuario);
            await _repo.SaveAsync();
        }
    }
}