using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Content_Element_Type_Conf : IEntityTypeConfiguration<Content_Element_Type>
    {
        public void Configure(EntityTypeBuilder<Content_Element_Type> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");
            builder.HasIndex(t => t.Name).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_content_element_types");
        }
    }
}

