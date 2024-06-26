using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendinbgSystem.Model.Products
{
    public class Coke : StockData
    {
        public override string Name => "コーラ";

        public override int Price => 180;

        public override int Amount { get; set; } = 5;
    }
}
