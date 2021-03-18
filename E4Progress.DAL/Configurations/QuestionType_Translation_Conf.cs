using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class QuestionType_Translation_Conf : IEntityTypeConfiguration<QuestionType_Translation>
    {
        public void Configure(EntityTypeBuilder<QuestionType_Translation> builder)
        {
            builder.Property(t => t.Translation)
                    .IsRequired()
                    .HasColumnType("varchar(40)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_questiontype_translations");
        }
    }
}