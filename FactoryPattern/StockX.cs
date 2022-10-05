using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FactoryPattern
{
    static class StockX
    {
        public static IShoeWear GetShoe(string shoeType)
        {
            switch (shoeType.ToLower())
            {
                case "nike":
                    return new Nike();
                case "adidas":
                    return new Adidas();
                case "jordan":
                    return new Jordan();
                default:
                    return new Nike();
            }
        }
    }
}
