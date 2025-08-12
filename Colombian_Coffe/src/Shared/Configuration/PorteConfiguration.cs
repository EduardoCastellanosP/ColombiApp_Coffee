using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class PorteConfiguration : IEntityTypeConfiguration<Porte>
    {
        public void Configure(EntityTypeBuilder<Porte> builder)
        {
            builder.ToTable("portes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

           
            builder.HasData(
                new Porte { Id = 1, Nombre = "Alto" },
                new Porte { Id = 2, Nombre = "Bajo" }
            );
        }
    }
}
