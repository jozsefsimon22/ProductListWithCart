using ProductListWithCart.Models;

namespace ProductListWithCart.Services;

public class CartService
{
    public Dictionary<Product, int> ProductsInCart { get; private set; } = new();
    
    public event Action? OnCartChange;
    
    public double CartTotal => ProductsInCart.Sum(product => product.Key.Price * product.Value);
    
    public int TotalCartItems => ProductsInCart.Sum(item => item.Value);

    public void Increment(Product product)
    {
        if (!ProductsInCart.TryAdd(product, 1))
        {
            ProductsInCart[product]++;
        }
        NotifyCartChange();
    }

    public void Decrement(Product product)
    {
        if (ProductsInCart.ContainsKey(product))
        {
            ProductsInCart[product]--;
            if (ProductsInCart[product] == 0)
            {
                ProductsInCart.Remove(product);
            }
            NotifyCartChange();
        }
    }

    public void CheckOut()
    {
        ProductsInCart.Clear();
        NotifyCartChange();
    }
    
    
    
    private void NotifyCartChange() => OnCartChange?.Invoke();
}