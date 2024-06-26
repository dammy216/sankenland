using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vendinbgSystem.Model.Products;

namespace vendinbgSystem.Model.Manager
{
    public class StockManager
    {
        private List<StockData> _stockList = new List<StockData>();
        public StockData[] StockList { get { return _stockList.ToArray(); } }
        private static StockManager _instance;

        private StockManager()
        {
            CreateStockList();
        }

        public static StockManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StockManager();
                return _instance;
            }
            return _instance;
        }

        private void CreateStockList()
        {
            _stockList = new List<StockData>
            {
                new Coke(),
                new Tea(),
            };
        }

        public string[] GetProductList(StockData stockData)
        {
            var name = stockData.Name;
            var amount = stockData.Amount.ToString();

            string[] products = { name, amount };
            return products;
        }

        public void AddStockAmount(StockData stockData, int amount)
        {
            stockData.Amount += amount;
        }

        public string[] GetStockList(StockData stockData)
        {
            var name = stockData.Name;
            var price  = stockData.Price.ToString();
            var amount = stockData.Amount.ToString();

            string[] stocks = { name, price, amount };
            return stocks;
        }
    }
}
