namespace MyApi.Models
{
    public class Item
{
    public int Id { get; set; }
    public string? Name { get; set; }        // Make nullable
    public string? Description { get; set; } // Make nullable
    public decimal Price { get; set; }
}
}
