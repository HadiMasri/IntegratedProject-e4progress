using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_Conf : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {

            //Foreign Key
            builder.Property(t => t.Question_TypeId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Is_Master_Question)
                    .IsRequired()
                    .HasColumnType("bit");

            //Foreign Key
            builder.Property(t => t.Master_QuestionId)
                    .HasColumnType("integer");

            builder.Property(t => t.Instruction_LanguageId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.UserInterface_LanguageId)
                    .HasColumnType("integer");

            builder.Property(t => t.Question_Formulation_TypeId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Office_ApplicationId)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(t => t.QuestionText)
                    .IsRequired()
                    .HasColumnType("text");

            builder.Property(t => t.Creation_timestamp)
                  .IsRequired()
                  .HasColumnType("date");

            builder.Property(t => t.Notes)
                    .HasColumnType("text");

            builder.Property(t => t.Version_Number)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.ReplicationKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            builder.HasIndex(t => t.ReplicationKey).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_questions");
        }
    }
}