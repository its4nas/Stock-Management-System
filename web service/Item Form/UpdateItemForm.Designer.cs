namespace web_service.Item_Form
{
    partial class UpdateItemForm
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
            this.old_item_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.item_input = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.update_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // old_item_input
            // 
            this.old_item_input.Location = new System.Drawing.Point(360, 71);
            this.old_item_input.Name = "old_item_input";
            this.old_item_input.Size = new System.Drawing.Size(201, 22);
            this.old_item_input.TabIndex = 15;
            this.old_item_input.TextChanged += new System.EventHandler(this.old_item_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Old Username";
            // 
            // item_input
            // 
            this.item_input.Location = new System.Drawing.Point(360, 204);
            this.item_input.Name = "item_input";
            this.item_input.Size = new System.Drawing.Size(201, 22);
            this.item_input.TabIndex = 13;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(239, 210);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 16);
            this.username.TabIndex = 12;
            this.username.Text = "New Username";
            // 
            // update_item
            // 
            this.update_item.Location = new System.Drawing.Point(388, 335);
            this.update_item.Name = "update_item";
            this.update_item.Size = new System.Drawing.Size(147, 44);
            this.update_item.TabIndex = 11;
            this.update_item.Text = "Update User";
            this.update_item.UseVisualStyleBackColor = true;
            this.update_item.Click += new System.EventHandler(this.update_item_Click);
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.old_item_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_input);
            this.Controls.Add(this.username);
            this.Controls.Add(this.update_item);
            this.Name = "UpdateItemForm";
            this.Text = "UpdateItemForm";
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox old_item_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_input;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button update_item;
    }
}