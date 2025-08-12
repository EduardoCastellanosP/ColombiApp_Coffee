using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class EnfermedadConfiguration : IEntityTypeConfiguration<Enfermedad>
    {
        public void Configure(EntityTypeBuilder<Enfermedad> builder)
        {
            builder.ToTable("enfermedades");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

            // Seed
            builder.HasData(
                new Enfermedad { Id = 1, Nombre = "Roya" },
                new Enfermedad { Id = 2, Nombre = "Antracnosis" },
                new Enfermedad { Id = 3, Nombre = "Nematodos" }
            );
        }
    }
}
