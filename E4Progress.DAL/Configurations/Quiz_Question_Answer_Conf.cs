using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Quiz_Question_Answer_Conf : IEntityTypeConfiguration<Quiz_Question_Answer>
    {
        public void Configure(EntityTypeBuilder<Quiz_Question_Answer> builder)
        {
            builder.HasKey(t => new { t.Question_Id, t.Quiz_Id,t.Question_Answer_Id });

            builder.Property(t => t.Fraction)
                    .IsRequired()
                    .HasColumnType("decimal(12,7)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_quiz_question_answers");
        }
    }
}
