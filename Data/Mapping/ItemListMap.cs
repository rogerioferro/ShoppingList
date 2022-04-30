using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingList.Models;

namespace ShoppingList.Data.Mapping;

public class ItemListMap : IEntityTypeConfiguration<ItemList>
{
    public void Configure(EntityTypeBuilder<ItemList> builder)
    {
        builder.ToTable("Item");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x=> x.CreatedAt)
            .IsRequired()
            .HasColumnName("CreatedAt")
            .HasColumnType("SMALLDATETIME")
            .HasMaxLength(60)
            .HasDefaultValue(DateTime.UtcNow);

        builder.Property(x => x.Done)
            .IsRequired()
            .HasColumnName("Done")
            .HasDefaultValue(false);

        builder
            .HasIndex(x => x.Name, "IX_Item_Name")
            .IsUnique();
    }
}