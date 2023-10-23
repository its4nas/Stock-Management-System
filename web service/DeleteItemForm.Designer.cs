namespace web_service
{
    partial class DeleteItemForm
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
            this.Item_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Item_input
            // 
            this.Item_input.Location = new System.Drawing.Point(360, 173);
            this.Item_input.Name = "Item_input";
            this.Item_input.Size = new System.Drawing.Size(201, 22);
            this.Item_input.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item name:";
            // 
            // delete_item
            // 
            this.delete_item.Location = new System.Drawing.Point(388, 233);
            this.delete_item.Name = "delete_item";
            this.delete_item.Size = new System.Drawing.Size(147, 44);
            this.delete_item.TabIndex = 18;
            this.delete_item.Text = "Delete Item";
            this.delete_item.UseVisualStyleBackColor = true;
            this.delete_item.Click += new System.EventHandler(this.delete_item_Click);
            // 
            // DeleteItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Item_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_item);
            this.Name = "DeleteItemForm";
            this.Text = "DeleteItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_item;
    }
}