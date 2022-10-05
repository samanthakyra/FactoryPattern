using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What kind of shoes are you looking to buy today? We have Nike, Adidas, or Jordan.");
            string userShoes = Console.ReadLine();

            IShoeWear shoe = StockX.GetShoe(userShoes);
            shoe.Build();
            Console.ReadLine();
        }
    }
}