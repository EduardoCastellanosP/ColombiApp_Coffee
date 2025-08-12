using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class CalidadAltitudNivelConfiguration : IEntityTypeConfiguration<CalidadAltitudNivel>
    {
        public void Configure(EntityTypeBuilder<CalidadAltitudNivel> builder)
        {
            builder.ToTable("calidad_altitud_nivel");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

            // Seed
            builder.HasData(
                new CalidadAltitudNivel { Id = 1, Nombre = "Nivel 1" },
                new CalidadAltitudNivel { Id = 2, Nombre = "Nivel 2" },
                new CalidadAltitudNivel { Id = 3, Nombre = "Nivel 3" },
                new CalidadAltitudNivel { Id = 4, Nombre = "Nivel 4" },
                new CalidadAltitudNivel { Id = 5, Nombre = "Nivel 5" }
            );
        }
    }
}
