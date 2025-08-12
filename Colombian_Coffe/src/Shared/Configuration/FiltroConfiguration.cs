using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Shared.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colombian_Coffe.src.Shared.Configuration
{
    public class FiltroConfiguration : IEntityTypeConfiguration<Filtro>
    {
        public void Configure(EntityTypeBuilder<Filtro> builder)
        {
            builder.ToTable("Filtros"); 
            // Configura la clave primaria (si la tienes)
            builder.HasKey(f => f.Id);

            // Propiedades (ejemplo)
            builder.Property(f => f.Porte)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(f => f.TamañoGrano)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(f => f.PotencialRendimiento)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(f => f.ResistenciaRoya)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(f => f.ResistenciaAntracnosis)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(f => f.ResistenciaNematodos)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(f => f.AltitudMinima).IsRequired(false);
            builder.Property(f => f.AltitudMaxima).IsRequired(false);
            builder.Property(f => f.CalidadGrano).IsRequired(false);

        }

    }
}