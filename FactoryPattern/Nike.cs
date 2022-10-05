using System;

namespace FactoryPattern
{
    class Nike : IShoeWear
    {
        public void Build()
        {
            ShoeStores.BuyingShoesDialogue();
            Console.WriteLine("Enjoy these Nikes!");
        }
    }
}