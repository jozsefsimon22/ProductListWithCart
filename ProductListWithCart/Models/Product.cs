namespace ProductListWithCart.Models;

public class Product
{
    public string Name { get; init; } = string.Empty; 
    public double Price { get; init; }
    public string ImageLink { get; init; } = string.Empty;
}