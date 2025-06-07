using ProductListWithCart.Models;

namespace ProductListWithCart.Data;

public static class DataRepository
{
    public static List<Product> Products { get; set; } =
    [
        new ()
        {
            Name = "Eggs",
            Price = 2.99,
            ImageLink = "eggs.png"
        },
        new ()
        {
            Name = "Cucumbers",
            Price = 1.49,
            ImageLink = "cucumber.png"
        },
        new ()
        {
            Name = "Cooking Oil",
            Price = 4.99,
            ImageLink = "oil.png"
        },
        new ()
        {
            Name = "Chicken Meat",
            Price = 10.46,
            ImageLink = "chicken.png"
        },
        new ()
        {
            Name = "Beef Steak",
            Price = 17.99,
            ImageLink = "beef.png"
        },
        new ()
        {
            Name = "Apples",
            Price = 1.97,
            ImageLink = "apples.png"
        },
        new ()
        {
            Name = "Potatoes",
            Price = 4.05,
            ImageLink = "potatoes.png"
        },
        new ()
        {
            Name = "Nescafe Coffee",
            Price = 11.64,
            ImageLink = "coffee.png"
        },
        new ()
        {
            Name = "Mulberry",
            Price = 4.99,
            ImageLink = "mulberry.png"
        },
        
    ];
    
}