using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Course_Module_Topic_Element_Conf : IEntityTypeConfiguration<Course_Module_Topic_Element>
    {
        public void Configure(EntityTypeBuilder<Course_Module_Topic_Element> builder)
        {
            //Foreign Key
            builder.Property(t => t.Content_Element_TypeId)
                    .IsRequired()
                    .HasColumnType("integer");
            builder.HasIndex(t => new { t.Content_Element_TypeId,t.Course_Module_TopicId, t.Content_ElementId }).IsUnique();

            builder.Property(t => t.Course_Module_TopicId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Content_ElementId)
                    .IsRequired()
                    .HasColumnType("integer");

            //Foreign Key
            builder.Property(t => t.Difficulty_LevelId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Sortorder)
                    .IsRequired()
                    .HasColumnType("integer");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_course_module_topic_elements");
        }
    }
}