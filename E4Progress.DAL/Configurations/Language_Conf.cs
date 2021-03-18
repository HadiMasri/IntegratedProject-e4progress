using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Language_Conf : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(t => t.Native_Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");
            builder.HasIndex(t => t.Native_Name).IsUnique();

            builder.Property(t => t.Code)
                    .IsRequired()
                    .HasColumnType("varchar(3)");
            builder.HasIndex(t => t.Code).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_languages");
        }
    }
}