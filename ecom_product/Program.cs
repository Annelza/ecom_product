using System;
using System.Diagnostics;
using ecom_product;
/// <summary>
/// Main class where execcution starts
/// </summary>
internal class Program
{
    public static void Main(string[] args)
    {
        // Enter user details
        Console.Write("Enter the product ID: ");
        var id = Console.ReadLine();
        Console.Write("Enter the product name: ");
        var name = Console.ReadLine();
        Console.Write("Enter the product price: ");
        var price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the stock count: ");
        var stock = Convert.ToInt32(Console.ReadLine());

        var productID = new Product(id);
        var productName = new Product(name);
        var productPrice = new Product(price);
        var productStock = new Product(stock);

        Console.Write("Enter the stock changed value: ");
        var value = Convert.ToInt32(Console.ReadLine());
        //getting chaged stock
        var increasedStock = productStock.StockIncrease(value);

        var decreasedStock = productStock.StockDecrease(value);

        //output
        Console.WriteLine($"Product ID : {id}");
        Console.WriteLine($"Product Name : {name}");
        Console.WriteLine($"Product Price : {price}");
        Console.WriteLine($"Product Stock : {stock}");
        Console.WriteLine($"Increased Stock : {increasedStock}");
        Console.WriteLine($"Decreased Stock : {decreasedStock}");
    }
}