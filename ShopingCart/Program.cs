var shoppingCart = new ShoppingCart();


List<Product> entries = new List<Product>();
for (int i = 0; i < 5; i++)
{
    string item= string.Empty;  
    int price = 0;

    Console.Write("please enter your item name:");
    item = Console.ReadLine();
    Console.Write("please enter price:");
    price = Convert.ToInt32(Console.ReadLine());


    var product = new Product(item, price);
    shoppingCart.AddProduct(product);
    entries.Add(product);

}


shoppingCart.GetTotalPrice();


