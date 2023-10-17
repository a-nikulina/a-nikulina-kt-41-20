using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using nikulinakt41_20.Database.Helpers;
using nikulinakt41_20.Models;


namespace nikulinakt41_20.Database.Configurations
{
    public class AcademicPerfomanceConfiguration : IEntityTypeConfiguration<AcademicPerfomance>
    {
        private const string TableName = "cd_academicperfomance";

        public void Configure(EntityTypeBuilder<AcademicPerfomance> builder)
        {
            builder
                .HasKey(p => p.PerfomanceId)
                .HasName($"pk_{TableName}_group_id");

            builder.Property(p => p.PerfomanceId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.PerfomanceId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор группы");
        }
    }
}
