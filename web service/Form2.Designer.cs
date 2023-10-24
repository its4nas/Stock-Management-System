namespace web_service
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.transaction = new System.Windows.Forms.Button();
            this.stocks = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.transaction);
            this.panel1.Controls.Add(this.stocks);
            this.panel1.Controls.Add(this.items);
            this.panel1.Controls.Add(this.users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1070, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 654);
            this.panel1.TabIndex = 0;
            // 
            // transaction
            // 
            this.transaction.Location = new System.Drawing.Point(24, 423);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(164, 75);
            this.transaction.TabIndex = 3;
            this.transaction.Text = "Transactions";
            this.transaction.UseVisualStyleBackColor = true;
            this.transaction.Click += new System.EventHandler(this.transaction_Click);
            // 
            // stocks
            // 
            this.stocks.Location = new System.Drawing.Point(24, 301);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(164, 75);
            this.stocks.TabIndex = 2;
            this.stocks.Text = "Stocks";
            this.stocks.UseVisualStyleBackColor = true;
            this.stocks.Click += new System.EventHandler(this.button1_Click);
            // 
            // items
            // 
            this.items.Location = new System.Drawing.Point(24, 174);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(164, 75);
            this.items.TabIndex = 1;
            this.items.Text = "Items";
            this.items.UseVisualStyleBackColor = true;
            this.items.Click += new System.EventHandler(this.items_Click);
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(24, 51);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(164, 75);
            this.users.TabIndex = 0;
            this.users.Text = "Users";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 654);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transactions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button items;
        private System.Windows.Forms.Button stocks;
        private System.Windows.Forms.Button transaction;
        private System.Windows.Forms.Button button1;
    }
}