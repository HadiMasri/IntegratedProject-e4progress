using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_Content_Theme_Conf : IEntityTypeConfiguration<Question_Content_Theme>
    {
        public void Configure(EntityTypeBuilder<Question_Content_Theme> builder)
        {
            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_question_content_themes");
        }
    }
}
