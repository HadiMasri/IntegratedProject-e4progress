using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class User_Conf : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Foreign Key
            builder.Property(t => t.LanguageId)
                    .IsRequired()
                    .HasColumnType("int");

            builder.Property(t => t.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            builder.HasIndex(t => t.Email).IsUnique();

            builder.Property(t => t.Firstname)
                    .HasColumnType("varchar(70)");

            builder.Property(t => t.Lastname)
                    .HasColumnType("varchar(70)");
            builder.Property(t => t.PasswordHash)
                  .HasColumnType("varbinary(400)");
            builder.Property(t => t.PasswordSalt)
                .HasColumnType("varbinary(400)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_users");
        }
    }
}
