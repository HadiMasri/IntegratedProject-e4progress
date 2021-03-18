using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Difficulty_Level_Conf : IEntityTypeConfiguration<Difficulty_Level>
    {
        public void Configure(EntityTypeBuilder<Difficulty_Level> builder)
        {
            builder.Property(t => t.Number)
                    .IsRequired()
                    .HasColumnType("integer");

            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(20)");       
            builder.HasIndex(t => t.Name).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_difficulty_levels");
        }
    }
}
