namespace web_service.Stocks_Form
{
    partial class UpdateStocksForm
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
            this.old_stock_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stock_input = new System.Windows.Forms.TextBox();
            this.stockname = new System.Windows.Forms.Label();
            this.update_stock = new System.Windows.Forms.Button();
            this.location_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // old_stock_input
            // 
            this.old_stock_input.ImeMode = System.Windows.Forms.ImeMode.On;
            this.old_stock_input.Location = new System.Drawing.Point(360, 138);
            this.old_stock_input.Name = "old_stock_input";
            this.old_stock_input.Size = new System.Drawing.Size(201, 22);
            this.old_stock_input.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Old stock name";
            // 
            // stock_input
            // 
            this.stock_input.Location = new System.Drawing.Point(360, 204);
            this.stock_input.Name = "stock_input";
            this.stock_input.Size = new System.Drawing.Size(201, 22);
            this.stock_input.TabIndex = 18;
            // 
            // stockname
            // 
            this.stockname.AutoSize = true;
            this.stockname.Location = new System.Drawing.Point(239, 210);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(106, 16);
            this.stockname.TabIndex = 17;
            this.stockname.Text = "New stock name";
            // 
            // update_stock
            // 
            this.update_stock.Location = new System.Drawing.Point(388, 335);
            this.update_stock.Name = "update_stock";
            this.update_stock.Size = new System.Drawing.Size(147, 44);
            this.update_stock.TabIndex = 16;
            this.update_stock.Text = "Update Stock";
            this.update_stock.UseVisualStyleBackColor = true;
            this.update_stock.Click += new System.EventHandler(this.update_stock_Click);
            // 
            // location_input
            // 
            this.location_input.Location = new System.Drawing.Point(360, 255);
            this.location_input.Name = "location_input";
            this.location_input.Size = new System.Drawing.Size(201, 22);
            this.location_input.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "New location name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UpdateStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.location_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.old_stock_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stock_input);
            this.Controls.Add(this.stockname);
            this.Controls.Add(this.update_stock);
            this.Name = "UpdateStocksForm";
            this.Text = "UpdateStocksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox old_stock_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stock_input;
        private System.Windows.Forms.Label stockname;
        private System.Windows.Forms.Button update_stock;
        private System.Windows.Forms.TextBox location_input;
        private System.Windows.Forms.Label label2;
    }
}