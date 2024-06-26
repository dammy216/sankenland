using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendinbgSystem.Model
{
    public abstract class StockData
    {
        public abstract string Name { get; }
        public abstract int Price { get; }
        public abstract int Amount { get; set; }
    }
}
