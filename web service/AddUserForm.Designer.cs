namespace web_service
{
    partial class AddUserForm
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
            this.user_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(330, 123);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(201, 22);
            this.user_input.TabIndex = 7;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(330, 197);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(201, 22);
            this.password_input.TabIndex = 8;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(212, 197);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(209, 129);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(70, 16);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(361, 274);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(147, 44);
            this.add_user.TabIndex = 4;
            this.add_user.Text = "Add User";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 521);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.add_user);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button add_user;
    }
}