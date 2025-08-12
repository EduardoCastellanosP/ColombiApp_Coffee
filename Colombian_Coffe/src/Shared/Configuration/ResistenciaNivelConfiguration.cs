using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class ResistenciaNivelConfiguration : IEntityTypeConfiguration<ResistenciaNivel>
    {
        public void Configure(EntityTypeBuilder<ResistenciaNivel> builder)
        {
            builder.ToTable("resistencia_nivel");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

            // Seed inicial
            builder.HasData(
                new ResistenciaNivel { Id = 1, Nombre = "Susceptible" },
                new ResistenciaNivel { Id = 2, Nombre = "Tolerante" },
                new ResistenciaNivel { Id = 3, Nombre = "Resistente" }
            );
        }
    }
}
