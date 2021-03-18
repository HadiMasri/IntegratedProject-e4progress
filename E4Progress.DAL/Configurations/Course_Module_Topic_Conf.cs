using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Course_Module_Topic_Conf : IEntityTypeConfiguration<Course_Module_Topic>
    {
        public void Configure(EntityTypeBuilder<Course_Module_Topic> builder)
        {

            //Foreign Key
            builder.Property(t => t.Course_ModuleId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");


            builder.Property(t => t.Sortorder)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.HasIndex(t => new { t.Course_ModuleId, t.Title, t.Sortorder }).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_course_module_topics");
        }
    }
}
