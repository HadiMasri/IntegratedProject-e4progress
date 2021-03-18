using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Content_Theme_Conf : IEntityTypeConfiguration<Content_Theme>
    {
        public void Configure(EntityTypeBuilder<Content_Theme> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(40)");
            builder.HasIndex(t => t.Name).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_content_themes");
        }
    }
}
