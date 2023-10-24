namespace web_service.Stocks_Form
{
    partial class DeleteStocksForm
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
            this.Stock_input = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.delete_stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stock_input
            // 
            this.Stock_input.Location = new System.Drawing.Point(360, 173);
            this.Stock_input.Name = "Stock_input";
            this.Stock_input.Size = new System.Drawing.Size(201, 22);
            this.Stock_input.TabIndex = 23;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(239, 176);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(81, 16);
            this.lable1.TabIndex = 22;
            this.lable1.Text = "Stock name:";
            // 
            // delete_stock
            // 
            this.delete_stock.Location = new System.Drawing.Point(388, 233);
            this.delete_stock.Name = "delete_stock";
            this.delete_stock.Size = new System.Drawing.Size(147, 44);
            this.delete_stock.TabIndex = 21;
            this.delete_stock.Text = "Delete Stock";
            this.delete_stock.UseVisualStyleBackColor = true;
            this.delete_stock.Click += new System.EventHandler(this.delete_stock_Click);
            // 
            // DeleteStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stock_input);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.delete_stock);
            this.Name = "DeleteStocksForm";
            this.Text = "DeleteStocksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Stock_input;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button delete_stock;
    }
}