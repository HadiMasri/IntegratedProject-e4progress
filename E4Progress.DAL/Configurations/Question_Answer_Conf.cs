using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_Answer_Conf : IEntityTypeConfiguration<Question_Answer>
    {
        public void Configure(EntityTypeBuilder<Question_Answer> builder)
        {
            //Foreign Key
            builder.Property(t => t.QuestionId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Answer)
                    .IsRequired()
                    .HasColumnType("text");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_question_answers");
        }
    }
}