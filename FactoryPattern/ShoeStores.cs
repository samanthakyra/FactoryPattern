using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPattern
{
    class ShoeStores
    {
        public static void BuyingShoesDialogue()
        {
            Console.WriteLine("Don't leave this page, as we secure you a pair!");
            Thread.Sleep(1000);
        }
    }
}