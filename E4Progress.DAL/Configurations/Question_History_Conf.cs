using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_History_Conf : IEntityTypeConfiguration<Question_History>
    {
        public void Configure(EntityTypeBuilder<Question_History> builder)
        {
            builder.Property(t => t.Question_ReplicationKey)
                      .IsRequired()
                      .HasColumnType("char(36)");

            builder.Property(t => t.Action)
                      .IsRequired()
                      .HasColumnType("char(1)");

            builder.Property(t => t.Action_Timestamp)
                      .IsRequired()
                      .HasColumnType("date");

            //Foreign Key
            builder.Property(t => t.Action_Done_By_User_Id)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Question_Type_Id)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Is_Master_Question)
                    .HasColumnType("bit");

            builder.Property(t => t.Master_Question_Id)
                    .HasColumnType("integer");

            builder.Property(t => t.Instruction_Language_Id)
                    .HasColumnType("integer");

            builder.Property(t => t.UserInterface_Language_Id)
                    .HasColumnType("integer");

            builder.Property(t => t.Question_Formulation_Type_Id)
                    .HasColumnType("integer");

            builder.Property(t => t.Office_Application_Id)
                    .HasColumnType("integer");

            builder.Property(t => t.Title)
                    .HasColumnType("varchar(100)");

            builder.Property(t => t.QuestionText)
                    .HasColumnType("text");

            builder.Property(t => t.Notes)
                    .HasColumnType("text");

            builder.Property(t => t.Version_Number)
                    .HasColumnType("integer");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_questions_history");
        }
    }
}