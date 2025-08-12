using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.modules.Filtros.Entities;
using Microsoft.EntityFrameworkCore;
using Colombian_Coffe.src.modules.Login.Entities;
using Colombian_Coffe.src.modules.Variedades.Entities;

namespace Colombian_Coffe.src.Shared.Context;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Login> Logins => Set<Login>();

    public DbSet<Filtro> Filtros => Set<Filtro>();

    public DbSet<Variedad> Variedades => Set<Variedad>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }


}


