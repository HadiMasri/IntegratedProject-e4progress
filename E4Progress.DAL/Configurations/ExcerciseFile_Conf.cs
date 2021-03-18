using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class ExcerciseFile_Conf : IEntityTypeConfiguration<ExcerciseFile>
    {
        public void Configure(EntityTypeBuilder<ExcerciseFile> builder)
        {
            builder.Property(t => t.Filename)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            builder.HasIndex(t => t.Filename).IsUnique();

            builder.Property(t => t.Contains_Currency)
                    .IsRequired()
                    .HasColumnType("bit");

            builder.Property(t => t.Contains_Date)
                    .IsRequired()
                    .HasColumnType("bit");

            builder.Property(t => t.Contains_Time)
                    .IsRequired()
                    .HasColumnType("bit");

            builder.Property(t => t.Contains_Geographical)
                    .IsRequired()
                    .HasColumnType("bit");

            builder.Property(t => t.Contains_Names_To_Translate)
                    .IsRequired()
                    .HasColumnType("bit");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_excercisefiles");
        }
    }
}