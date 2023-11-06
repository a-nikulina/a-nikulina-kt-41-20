using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using nikulinakt41_20.Database.Helpers;
using nikulinakt41_20.Models;

namespace nikulinakt41_20.Database.Configurations
{
    public class GroupCofiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "cd_group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(p => p.GroupId)
                .HasName($"pk_{TableName}_group_id");

            builder.Property(p => p.GroupId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор группы");

            builder.Property(p => p.GroupName)
                .IsRequired()
                .HasColumnName("c_group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Наименование группы");

            builder.ToTable(TableName);
        }
    }
}
