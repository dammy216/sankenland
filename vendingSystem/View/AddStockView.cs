using System;
using System.Windows.Forms;
using vendinbgSystem.Model;
using vendinbgSystem.Model.Manager;

namespace vendingSystem.View
{
    public partial class AddStockView : Form
    {
        private StockManager _stockInstance = StockManager.GetInstance();
        public AddStockView()
        {   
            InitializeComponent();
            DisplayProductListView();
        }

        private void DisplayProductListView()
        {
            productListView.Items.Clear();

            foreach (var stock in _stockInstance.StockList)
            {
                var stockList = _stockInstance.GetProductList(stock);

                if (stockList == null) return;

                ListViewItem item = new ListViewItem(stockList);
                item.Tag = stock;
                productListView.Items.Add(item);
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            _stockInstance.AddStockAmount(productListView.SelectedItems[0].Tag as StockData, (int)amountNB.Value);
            DisplayProductListView();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
