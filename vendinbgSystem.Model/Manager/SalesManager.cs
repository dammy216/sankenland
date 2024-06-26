using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendinbgSystem.Model.Manager
{
    public class SalesManager
    {
        private int _money = 0;
        private static SalesManager _instance;

        private SalesManager() { }

        public static SalesManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SalesManager();
                return _instance;
            }
            return _instance;
        }

        public void SalesProductAmount(StockData data) => data.Amount--;

        public int AddedMoney(int money) => _money += money;

        public int CalcChange(StockData data) =>  _money -= data.Price;

        public void ResetMoney() => _money = 0;
    }
}
