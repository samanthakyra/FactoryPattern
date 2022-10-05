using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Threading;

namespace FactoryPattern
{
    class Adidas : IShoeWear
    {
        public void Build()
        {
            ShoeStores.BuyingShoesDialogue();
            Console.WriteLine("Enjoy these pairs of Adidas");
        }
    }
}