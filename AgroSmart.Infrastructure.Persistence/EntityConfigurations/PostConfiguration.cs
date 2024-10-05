using AgroSmart.Core.Domain.Entities;
using AgroSmart.Infraestructure.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroSmart.Infraestructure.Persistence.EntityConfigurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            // Tabla en la base de datos
            builder.ToTable("Posts");

            // Definir la clave primaria
            builder.HasKey(p => p.Id);

            // Configuración de las propiedades
            builder.Property(p => p.Content)
                .IsRequired() // Obligatorio
                .HasMaxLength(1000); // Longitud máxima de 1000 caracteres

            builder.Property(p => p.UserId)
                .IsRequired(); // UserId es obligatorio

            // Configurar la relación con ApplicationUser
            builder.HasOne<ApplicationUser>()
                .WithMany() // Si ApplicationUser tiene una colección de Post
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Eliminar en cascada

            // Relación con el Topic
            builder.HasOne(p => p.Topic)
                .WithMany(t => t.Posts)
                .HasForeignKey(p => p.TopicId)
                .OnDelete(DeleteBehavior.Restrict); // Eliminar en cascada

            // Configurar columnas comunes (opcional si tienes propiedades como Created, Modified, etc.)
            builder.Property(p => p.Created)
                .IsRequired();

            builder.Property(p => p.LastModified)
                .IsRequired(false);
        }
    }
}
