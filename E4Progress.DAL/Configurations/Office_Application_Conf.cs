using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Office_Application_Conf : IEntityTypeConfiguration<Office_Application>
    {
        public void Configure(EntityTypeBuilder<Office_Application> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");
            builder.HasIndex(t => t.Name).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_office_applications");
        }
    }
}