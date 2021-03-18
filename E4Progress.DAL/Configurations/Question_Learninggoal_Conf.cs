using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_Learninggoal_Conf : IEntityTypeConfiguration<Question_Learninggoal>
    {
        public void Configure(EntityTypeBuilder<Question_Learninggoal> builder)
        {
            //Foreign Key
            builder.Property(t => t.QuestionId)
                    .IsRequired()
                    .HasColumnType("integer");
            builder.HasIndex(t => t.QuestionId).IsUnique();

            builder.Property(t => t.Didactical_Model_LevelId)
                    .IsRequired()
                    .HasColumnType("integer");
            //
            builder.Property(t => t.Learninggoal)
                    .IsRequired()
                    .HasColumnType("text");

            builder.Property(t => t.Is_Measurable)
                    .IsRequired()
                    .HasColumnType("bit");

            builder.Property(t => t.Notes)
                    .HasColumnType("text");

            builder.Property(t => t.Sortorder)
                    .HasColumnType("integer");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_question_learninggoals");
        }
    }
}