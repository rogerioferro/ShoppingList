namespace ShoppingList.Models;

public class ItemList
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool Done { get; set; }
    List<Item> Items { get; set; } = new();
}