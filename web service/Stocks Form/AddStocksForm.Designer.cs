namespace web_service.Stocks_Form
{
    partial class AddStocksForm
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
            this.stocks_input = new System.Windows.Forms.TextBox();
            this.stockname = new System.Windows.Forms.Label();
            this.add_stock = new System.Windows.Forms.Button();
            this.stockslocation_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stocks_input
            // 
            this.stocks_input.Location = new System.Drawing.Point(380, 220);
            this.stocks_input.Name = "stocks_input";
            this.stocks_input.Size = new System.Drawing.Size(201, 22);
            this.stocks_input.TabIndex = 14;
            // 
            // stockname
            // 
            this.stockname.AutoSize = true;
            this.stockname.Location = new System.Drawing.Point(239, 220);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(78, 16);
            this.stockname.TabIndex = 13;
            this.stockname.Text = "Stock name";
            // 
            // add_stock
            // 
            this.add_stock.Location = new System.Drawing.Point(409, 320);
            this.add_stock.Name = "add_stock";
            this.add_stock.Size = new System.Drawing.Size(147, 44);
            this.add_stock.TabIndex = 15;
            this.add_stock.Text = "Add Stocks";
            this.add_stock.UseVisualStyleBackColor = true;
            this.add_stock.Click += new System.EventHandler(this.add_stock_Click);
            // 
            // stockslocation_input
            // 
            this.stockslocation_input.Location = new System.Drawing.Point(380, 258);
            this.stockslocation_input.Name = "stockslocation_input";
            this.stockslocation_input.Size = new System.Drawing.Size(201, 22);
            this.stockslocation_input.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Stock location name";
            // 
            // AddStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockslocation_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_stock);
            this.Controls.Add(this.stocks_input);
            this.Controls.Add(this.stockname);
            this.Name = "AddStocksForm";
            this.Text = "AddStocksForm";
            this.Load += new System.EventHandler(this.AddStocksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stocks_input;
        private System.Windows.Forms.Label stockname;
        private System.Windows.Forms.Button add_stock;
        private System.Windows.Forms.TextBox stockslocation_input;
        private System.Windows.Forms.Label label1;
    }
}