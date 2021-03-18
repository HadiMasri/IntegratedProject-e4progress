using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_Pre_Knowledge_Skill_Conf : IEntityTypeConfiguration<Question_Pre_Knowledge_Skill>
    {
        public void Configure(EntityTypeBuilder<Question_Pre_Knowledge_Skill> builder)
        {
            builder.Property(t => t.Skill)
                    .IsRequired()
                    .HasColumnType("text");

            //Foreign Key
            builder.Property(t => t.QuestionId)
                    .IsRequired()
                    .HasColumnType("integer");
            builder.HasIndex(t => t.QuestionId).IsUnique();

            builder.Property(t => t.Sortorder)
                    .HasColumnType("integer");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_question_pre_knowledge_skills");
        }
    }
}