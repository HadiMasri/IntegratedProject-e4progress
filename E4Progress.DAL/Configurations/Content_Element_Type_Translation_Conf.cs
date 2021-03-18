using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Content_Element_Type_Translation_Conf : IEntityTypeConfiguration<Content_Element_Type_Translation>
    {
        public void Configure(EntityTypeBuilder<Content_Element_Type_Translation> builder)
        {
            //builder.HasKey(t => new { t.Content_Element_Type_Id, t.Language_Id });
            builder.Property(t => t.Translation)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_content_element_type_translations");
        }
    }
}
