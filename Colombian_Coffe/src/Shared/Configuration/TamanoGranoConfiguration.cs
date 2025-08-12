using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class TamanoGranoConfiguration : IEntityTypeConfiguration<TamanoGrano>
    {
        public void Configure(EntityTypeBuilder<TamanoGrano> builder)
        {
            builder.ToTable("tamanos_grano");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

            // Seed inicial
            builder.HasData(
                new TamanoGrano { Id = 1, Nombre = "Pequeño" },
                new TamanoGrano { Id = 2, Nombre = "Medio" },
                new TamanoGrano { Id = 3, Nombre = "Grande" }
            );
        }
    }
}
