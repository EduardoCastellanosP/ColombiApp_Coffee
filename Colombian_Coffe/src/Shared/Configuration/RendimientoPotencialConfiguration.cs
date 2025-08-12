using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class RendimientoPotencialConfiguration : IEntityTypeConfiguration<RendimientoPotencial>
    {
        public void Configure(EntityTypeBuilder<RendimientoPotencial> builder)
        {
            builder.ToTable("rendimiento_potencial");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

            // Seed
            builder.HasData(
                new RendimientoPotencial { Id = 1, Nombre = "Muy bajo" },
                new RendimientoPotencial { Id = 2, Nombre = "Bajo" },
                new RendimientoPotencial { Id = 3, Nombre = "Medio" },
                new RendimientoPotencial { Id = 4, Nombre = "Alto" },
                new RendimientoPotencial { Id = 5, Nombre = "Excepcional" }
            );
        }
    }
}
