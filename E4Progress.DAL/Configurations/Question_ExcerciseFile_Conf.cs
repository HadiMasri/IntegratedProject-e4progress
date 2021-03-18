using E4Progress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E4Progress.DAL.Configurations
{
    public class Question_ExcerciseFile_Conf : IEntityTypeConfiguration<Question_ExerciseFile>
    {
        public void Configure(EntityTypeBuilder<Question_ExerciseFile> builder)
        {
            builder.HasKey(t => new { t.ExerciseFile_Id, t.Question_Id });

            //VUL HIER ENTITYRELATION

            builder.ToTable("tbl_question_exercisefiles");
        }
    }
}