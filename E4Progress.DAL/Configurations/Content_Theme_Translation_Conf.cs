using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Content_Theme_Translation_Conf : IEntityTypeConfiguration<Content_Theme_Translation>
    {
        public void Configure(EntityTypeBuilder<Content_Theme_Translation> builder)
        {
            builder.HasKey(t => new { t.Content_Theme_Id, t.Language_Id });
            builder.Property(t => t.Translation)
                    .IsRequired()
                    .HasColumnType("varchar(40)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_content_theme_translations");
        }
    }
}
