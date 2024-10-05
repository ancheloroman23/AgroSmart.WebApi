using AgroSmart.Core.Domain.Entities;
using AgroSmart.Infraestructure.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroSmart.Infraestructure.Persistence.EntityConfigurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            // Tabla en la base de datos
            builder.ToTable("Topics");

            // Definir la clave primaria
            builder.HasKey(t => t.Id);

            // Configuración de las propiedades
            builder.Property(t => t.Title)
                .IsRequired() // Obligatorio
                .HasMaxLength(200); // Longitud máxima de 200 caracteres

            builder.Property(t => t.UserId)
                .IsRequired(); // UserId es obligatorio

            // Configurar la relación con ApplicationUser
            builder.HasOne<ApplicationUser>()
                .WithMany() // Si ApplicationUser tiene una colección de Topic
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Eliminar en cascada

            // Relación con los posts
            builder.HasMany(t => t.Posts)
                .WithOne(p => p.Topic)
                .HasForeignKey(p => p.TopicId)
                .OnDelete(DeleteBehavior.Cascade); // Eliminar en cascada

            // Configurar columnas comunes (opcional si tienes propiedades como Created, Modified, etc.)
            builder.Property(t => t.Created)
                .IsRequired();

            builder.Property(t => t.LastModified)
                .IsRequired(false);
        }
    }
}
