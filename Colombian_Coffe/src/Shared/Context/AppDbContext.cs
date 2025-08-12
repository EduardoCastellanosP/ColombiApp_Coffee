using Microsoft.EntityFrameworkCore;

using Colombian_Coffe.src.Modules.Variedades.Entities;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;
using Colombian_Coffe.src.Modules.Variedades.Application.Interfaces;

namespace Colombian_Coffe.src.Shared.Context;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    
        public DbSet<Variedad> Variedades => Set<Variedad>();
        public DbSet<Porte> Portes => Set<Porte>();
        public DbSet<TamanoGrano> TamanosGrano => Set<TamanoGrano>();
        public DbSet<RendimientoPotencial> RendimientosPotenciales => Set<RendimientoPotencial>();
        public DbSet<CalidadAltitudNivel> CalidadAltitudNiveles => Set<CalidadAltitudNivel>();
        public DbSet<Enfermedad> Enfermedades => Set<Enfermedad>();
        public DbSet<ResistenciaNivel> ResistenciaNiveles => Set<ResistenciaNivel>();
        public DbSet<VariedadResistencia> VariedadResistencias => Set<VariedadResistencia>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

