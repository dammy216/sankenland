using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendinbgSystem.Model.Products
{
    public class Tea : StockData
    {
        public override string Name => "茶";

        public override int Price => 140;
        public override int Amount { get; set; } = 5;
    }
}
