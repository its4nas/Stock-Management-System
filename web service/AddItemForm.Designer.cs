namespace web_service
{
    partial class AddItemForm
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
            this.item_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item_input
            // 
            this.item_input.Location = new System.Drawing.Point(360, 128);
            this.item_input.Name = "item_input";
            this.item_input.Size = new System.Drawing.Size(201, 22);
            this.item_input.TabIndex = 12;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(360, 202);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(201, 22);
            this.password_input.TabIndex = 13;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(242, 202);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(239, 134);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(69, 16);
            this.username.TabIndex = 11;
            this.username.Text = "Item name";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(391, 279);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(147, 44);
            this.add_user.TabIndex = 9;
            this.add_user.Text = "Add User";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.item_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.add_user);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button add_user;
    }
}