namespace ShoppingList.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Done { get; set; }
    public int Quantity { get; set; }
}