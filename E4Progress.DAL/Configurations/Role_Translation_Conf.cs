using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Role_Translation_Conf : IEntityTypeConfiguration<Role_Translation>
    {
        public void Configure(EntityTypeBuilder<Role_Translation> builder)
        {
            builder.HasKey(t => new { t.Role_Id, t.Language_Id });
            builder.Property(t => t.Translation)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_role_translations");
        }
    }
}