using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vendinbgSystem.Model;
using vendinbgSystem.Model.Manager;
using vendingSystem.View;

namespace vendingSystem
{
    public partial class VendingMachine : Form
    {
        private StockManager _stockInstance = StockManager.GetInstance();
        private SalesManager _salesInstance = SalesManager.GetInstance();
        public VendingMachine()
        {
            InitializeComponent();
            DisplayStockList();
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            var addStock = new AddStockView();
            if(addStock.ShowDialog() == DialogResult.OK)
            {
                DisplayStockList();
            }
        }

        private void DisplayStockList()
        {
            stockListView.Items.Clear();

            foreach (var stock in _stockInstance.StockList)
            {
                var stockList = _stockInstance.GetStockList(stock);

                if (stockList == null) return;

                ListViewItem item = new ListViewItem(stockList);
                item.Tag = stock;
                stockListView.Items.Add(item);
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            _salesInstance.SalesProductAmount(stockListView.SelectedItems[0].Tag as StockData);
            totalMoneyLabel.Text = $"投入金額:{_salesInstance.CalcChange(stockListView.SelectedItems[0].Tag as StockData)}";
            DisplayStockList();
        }

        private void insertMoneyButton_Click(object sender, EventArgs e)
        {
            totalMoneyLabel.Text = $"投入金額{_salesInstance.AddedMoney((int)inputMoneyNB.Value)}";
        }
    }
}
