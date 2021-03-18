using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Didactical_Model_Level_Conf : IEntityTypeConfiguration<Didactical_Model_Level>
    {
        public void Configure(EntityTypeBuilder<Didactical_Model_Level> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(30)");
            builder.HasIndex(t => t.Name).IsUnique();

            builder.Property(t => t.Sortorder)
                    .IsRequired()
                    .HasColumnType("integer");
            builder.HasIndex(t => t.Sortorder);

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_didactical_model_levels");
        }
    }
}