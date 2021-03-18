using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Role_Conf : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");
            builder.HasIndex(t => t.Name).IsUnique();

            builder.Property(t => t.Display_Label)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_roles");
        }
    }
}