namespace web_service
{
    partial class StocksForm
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
            this.showallstocks = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.showallstocks);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(948, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 570);
            this.panel1.TabIndex = 2;
            // 
            // showallstocks
            // 
            this.showallstocks.BackColor = System.Drawing.SystemColors.Info;
            this.showallstocks.Location = new System.Drawing.Point(20, 461);
            this.showallstocks.Name = "showallstocks";
            this.showallstocks.Size = new System.Drawing.Size(154, 67);
            this.showallstocks.TabIndex = 4;
            this.showallstocks.Text = "show all stocks";
            this.showallstocks.UseVisualStyleBackColor = false;
            this.showallstocks.Click += new System.EventHandler(this.showallstocks_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.Info;
            this.add_button.Location = new System.Drawing.Point(20, 48);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(154, 66);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Create Stock";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click_1);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.Info;
            this.delete_button.Location = new System.Drawing.Point(20, 329);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(154, 67);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Delete Stock";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click_1);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.Info;
            this.update_button.Location = new System.Drawing.Point(20, 189);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(154, 67);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Edit Stock";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 570);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 195);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "StocksForm";
            this.Text = "StocksForm";
            this.Load += new System.EventHandler(this.StocksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showallstocks;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}