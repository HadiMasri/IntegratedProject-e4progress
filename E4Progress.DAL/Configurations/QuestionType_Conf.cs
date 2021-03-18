using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class QuestionType_Conf : IEntityTypeConfiguration<QuestionType>
    {
        public void Configure(EntityTypeBuilder<QuestionType> builder)
        {
            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasColumnType("varchar(40)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_questiontypes");
        }
    }
}