using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class VariedadResistenciaConfig : IEntityTypeConfiguration<VariedadResistencia>
    {
        public void Configure(EntityTypeBuilder<VariedadResistencia> builder)
        {
            builder.ToTable("variedad_resistencias");

            builder.HasKey(x => x.Id);

           
            builder.HasIndex(x => new { x.VariedadId, x.EnfermedadId })
                   .IsUnique();

            // Índices de FKs para las consultas
            builder.HasIndex(x => x.VariedadId);
            builder.HasIndex(x => x.EnfermedadId);
            builder.HasIndex(x => x.NivelId);

            // puse aqui las Relaciones entre tablas pilas
            builder.HasOne<Variedad>()
                   .WithMany()
                   .HasForeignKey(x => x.VariedadId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Enfermedad>()
                   .WithMany()
                   .HasForeignKey(x => x.EnfermedadId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<ResistenciaNivel>()
                   .WithMany()
                   .HasForeignKey(x => x.NivelId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
