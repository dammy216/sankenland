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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
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
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(553, 294);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "購入";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "投入金額:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(83, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(366, 259);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}

