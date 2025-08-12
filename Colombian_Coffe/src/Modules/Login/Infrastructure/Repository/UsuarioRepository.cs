using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Login.Application.Interfaces;
using Colombian_Coffe.src.Modules.Login.Domain.Entities;
using Colombian_Coffe.src.Shared.Context;
using Microsoft.EntityFrameworkCore;

namespace Colombian_Coffe.src.Modules.Login.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Usuario?> GetByIdAsync(int id)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<IEnumerable<Usuario?>> GetAllAsync() =>
            await _context.Usuarios.ToListAsync();
        public void Add(Usuario usuario) =>
            _context.Usuarios.Add(usuario);
        public async Task SaveAsync() =>
        await _context.SaveChangesAsync();
    }
}