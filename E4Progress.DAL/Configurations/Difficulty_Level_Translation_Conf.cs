using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Difficulty_Level_Translation_Conf : IEntityTypeConfiguration<Difficulty_Level_Translation>
    {
        public void Configure(EntityTypeBuilder<Difficulty_Level_Translation> builder)
        {
            builder.Property(t => t.Translation)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_difficulty_level_translations");
        }
    }
}