using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;

namespace ShoppingList.Data;

public class ShoppingListDataContext : DbContext
{
    public DbSet<Item> Items { get; set; } = null!;
    public DbSet<ItemList> ItemLists { get; set; } = null!;
}