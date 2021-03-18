using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Didactical_Model_Level_Translation_Conf : IEntityTypeConfiguration<Didactical_Model_Level_Translation>
    {
        public void Configure(EntityTypeBuilder<Didactical_Model_Level_Translation> builder)
        {
            builder.Property(t => t.Translation)
                    .HasColumnType("varchar(30)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_didactical_model_level_translations");
        }
    }
}