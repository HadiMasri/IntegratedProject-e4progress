using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Language_Translation_Conf : IEntityTypeConfiguration<Language_Translation>
    {
        public void Configure(EntityTypeBuilder<Language_Translation> builder)
        {
            builder.Property(t => t.Translation)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_language_translations");
        }
    }
}