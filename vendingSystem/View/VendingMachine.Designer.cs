namespace vendingSystem
{
    partial class VendingMachine
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.addStockButton = new System.Windows.Forms.Button();
            this.inputMoneyNB = new System.Windows.Forms.NumericUpDown();
            this.insertMoneyButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.totalMoneyLabel = new System.Windows.Forms.Label();
            this.stockListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.inputMoneyNB)).BeginInit();
            this.SuspendLayout();
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(687, 400);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(75, 23);
            this.addStockButton.TabIndex = 0;
            this.addStockButton.Text = "add";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // inputMoneyNB
            // 
            this.inputMoneyNB.Location = new System.Drawing.Point(530, 135);
            this.inputMoneyNB.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inputMoneyNB.Name = "inputMoneyNB";
            this.inputMoneyNB.Size = new System.Drawing.Size(120, 19);
            this.inputMoneyNB.TabIndex = 1;
            // 
            // insertMoneyButton
            // 
            this.insertMoneyButton.Location = new System.Drawing.Point(553, 178);
            this.insertMoneyButton.Name = "insertMoneyButton";
            this.insertMoneyButton.Size = new System.Drawing.Size(75, 23);
            this.insertMoneyButton.TabIndex = 2;
            this.insertMoneyButton.Text = "投入";
            this.insertMoneyButton.UseVisualStyleBackColor = true;
            this.insertMoneyButton.Click += new System.EventHandler(this.insertMoneyButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(553, 294);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "購入";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // totalMoneyLabel
            // 
            this.totalMoneyLabel.AutoSize = true;
            this.totalMoneyLabel.Location = new System.Drawing.Point(687, 141);
            this.totalMoneyLabel.Name = "totalMoneyLabel";
            this.totalMoneyLabel.Size = new System.Drawing.Size(55, 12);
            this.totalMoneyLabel.TabIndex = 4;
            this.totalMoneyLabel.Text = "投入金額:";
            // 
            // stockListView
            // 
            this.stockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.stockListView.FullRowSelect = true;
            this.stockListView.HideSelection = false;
            this.stockListView.Location = new System.Drawing.Point(128, 58);
            this.stockListView.Name = "stockListView";
            this.stockListView.Size = new System.Drawing.Size(307, 259);
            this.stockListView.TabIndex = 5;
            this.stockListView.UseCompatibleStateImageBehavior = false;
            this.stockListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "売値";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "在庫数";
            this.columnHeader3.Width = 100;
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockListView);
            this.Controls.Add(this.totalMoneyLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.insertMoneyButton);
            this.Controls.Add(this.inputMoneyNB);
            this.Controls.Add(this.addStockButton);
            this.Name = "VendingMachine";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputMoneyNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.NumericUpDown inputMoneyNB;
        private System.Windows.Forms.Button insertMoneyButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label totalMoneyLabel;
        private System.Windows.Forms.ListView stockListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

