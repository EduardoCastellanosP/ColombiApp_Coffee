using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Shared.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nombre)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.Clave)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}