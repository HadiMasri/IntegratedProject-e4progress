using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_Formulation_Type_Conf : IEntityTypeConfiguration<Question_Formulation_Type>
    {
        public void Configure(EntityTypeBuilder<Question_Formulation_Type> builder)
        {
            builder.Property(t => t.Name)
                    .HasColumnType("varchar(20)");

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_question_formulation_types");
        }
    }
}