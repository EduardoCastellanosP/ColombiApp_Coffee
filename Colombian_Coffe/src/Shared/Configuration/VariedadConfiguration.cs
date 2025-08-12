using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Config
{
    public class VariedadConfiguration : IEntityTypeConfiguration<Variedad>
    {
        public void Configure(EntityTypeBuilder<Variedad> builder)
        {
            builder.ToTable("variedades");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.HasIndex(x => x.Nombre)
                   .IsUnique();

            builder.Property(x => x.NombreCientifico)
                   .HasMaxLength(150);

            builder.Property(x => x.ImagenRelativa)
                .HasMaxLength(300);

            builder.Property(x => x.TiempoCosecha).HasMaxLength(120);
            builder.Property(x => x.Maduracion).HasMaxLength(120);
            builder.Property(x => x.DensidadSiembra).HasMaxLength(120);
            builder.Property(x => x.Obtentor).HasMaxLength(150);
            builder.Property(x => x.Familia).HasMaxLength(150);
            builder.Property(x => x.GrupoGenetico).HasMaxLength(150);

            // Timestamps manejados por MySQL
            builder.Property(x => x.CreadoEn)
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(x => x.ActualizadoEn)
                   .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

            // Relaciones a catálogos y aquí se hace SET NULL si se borra un catálogo
            builder.HasOne<Porte>()
                   .WithMany()
                   .HasForeignKey(x => x.PorteId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<TamanoGrano>()
                   .WithMany()
                   .HasForeignKey(x => x.TamanoGranoId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<RendimientoPotencial>()
                   .WithMany()
                   .HasForeignKey(x => x.RendimientoPotencialId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<CalidadAltitudNivel>()
                   .WithMany()
                   .HasForeignKey(x => x.CalidadAltitudNivelId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Regla de coherencia para altitud
            builder.HasCheckConstraint(
                "chk_altitud_rango",
                "(AltitudMin IS NULL OR AltitudMax IS NULL OR AltitudMin <= AltitudMax)"
            );
        }
    }
}
