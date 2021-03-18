using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Quiz_Conf : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.Property(t => t.Office_Application_Id)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Instruction_Language_Id)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Userinterface_Language_Id)
                    .HasColumnType("integer");

            builder.Property(t => t.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

            builder.Property(t => t.Short_Intro)
                    .HasColumnType("text");

            builder.Property(t => t.Intro)
                    .HasColumnType("text");

            builder.Property(t => t.Default_Time_Limit)
                    .IsRequired()
                    .HasColumnType("time");

            builder.Property(t => t.Default_Minimum_Score)
                    .IsRequired()
                    .HasColumnType("decimal(12,7)");

            builder.Property(t => t.Identification_Code)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(t => t.ReplicationKey)
                    .IsRequired()
                    .HasColumnType("char(36)");

            builder.HasIndex(t => new { t.Office_Application_Id, t.Identification_Code }).IsUnique();
            builder.HasIndex(t => t.ReplicationKey).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_quizzes");
        }
    }
}

