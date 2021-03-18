using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Didactical_Model_Conf : IEntityTypeConfiguration<Didactical_Model>
    {
        public void Configure(EntityTypeBuilder<Didactical_Model> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

            builder.HasIndex(t => t.Name).IsUnique();

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_didactical_models");
        }
    }
}