using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Course_Conf : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

            builder.Property(t => t.Created_By)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Created_On)
                    .IsRequired()
                    .HasColumnType("date");

            builder.Property(t => t.ReplicationKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            builder.HasIndex(t => t.ReplicationKey).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_courses");
        }
    }
}