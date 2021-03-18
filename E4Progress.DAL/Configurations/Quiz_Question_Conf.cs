using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Quiz_Question_Conf : IEntityTypeConfiguration<Quiz_Question>
    {
        public void Configure(EntityTypeBuilder<Quiz_Question> builder)
        {
            builder.HasKey(t => new { t.Quiz_Id, t.Question_Id });

            builder.Property(t => t.Quiz_Id)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsRequired();

            builder.Property(t => t.Question_Id)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsRequired();

            builder.Property(t => t.Sortorder)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsRequired();

            builder.HasIndex(t => new { t.Quiz_Id, t.Sortorder }).IsUnique();

            builder.ToTable("tbl_quiz_questions");
        }
    }
}