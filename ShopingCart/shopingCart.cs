
using System.Diagnostics.Contracts;

public class ShoppingCart
{
    public readonly List<Product> _product;
    public ShoppingCart()
    {
        _product = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public void GetTotalPrice()

    {
        double total = 0;
        foreach (Product item in _product)
        {

            total += (item.price);
        }
        Console.WriteLine($"Total price of your orders is : {total}");



    }
}
