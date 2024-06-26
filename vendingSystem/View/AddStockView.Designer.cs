namespace vendingSystem.View
{
    partial class AddStockView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountNB = new System.Windows.Forms.NumericUpDown();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountNB)).BeginInit();
            this.SuspendLayout();
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.productListView.FullRowSelect = true;
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(114, 86);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(204, 272);
            this.productListView.TabIndex = 0;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "在庫数";
            this.columnHeader2.Width = 100;
            // 
            // amountNB
            // 
            this.amountNB.Location = new System.Drawing.Point(409, 174);
            this.amountNB.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.amountNB.Name = "amountNB";
            this.amountNB.Size = new System.Drawing.Size(120, 19);
            this.amountNB.TabIndex = 1;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(428, 318);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 23);
            this.purchaseButton.TabIndex = 2;
            this.purchaseButton.Text = "仕入れる";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(645, 318);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.amountNB);
            this.Controls.Add(this.productListView);
            this.Name = "AddStockView";
            this.Text = "AddStockView";
            ((System.ComponentModel.ISupportInitialize)(this.amountNB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NumericUpDown amountNB;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button closeButton;
    }
}