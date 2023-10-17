using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using nikulinakt41_20.Database.Helpers;
using nikulinakt41_20.Models;

namespace nikulinakt41_20.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "cd_subject";

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .HasKey(p => p.SubjectId)
                .HasName($"pk_{TableName}_subject_id");

            builder.Property(p => p.SubjectId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.SubjectId)
                .HasColumnName("subject_id")
                .HasComment("Идентификатор предмета");

            builder.Property(p => p.SubjectName)
                .IsRequired()
                .HasColumnName("c_subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Наименование приедмета");

            builder.Property(p => p.Teacher)
                .IsRequired()
                .HasColumnName("c_teacher_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Преподаватель");

            builder.ToTable(TableName)
                .HasOne(p => p.AcademicPerfomance)
                .WithMany()
                .HasForeignKey(p => p.SubjectId)
                .HasConstraintName("fk_f_subject_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.SubjectId, $"idx_{TableName}_fk_f_subject_id");

            builder.Navigation(p => p.SubjectName)
                .AutoInclude();
        }
    }
}
