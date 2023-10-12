namespace web_service
{
    partial class UpdateUserForm
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
            this.update_user = new System.Windows.Forms.Button();
            this.old_user_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(304, 184);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(201, 22);
            this.user_input.TabIndex = 7;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(304, 258);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(201, 22);
            this.password_input.TabIndex = 8;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(186, 258);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(97, 16);
            this.password.TabIndex = 5;
            this.password.Text = "New Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(183, 190);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 16);
            this.username.TabIndex = 6;
            this.username.Text = "New Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // update_user
            // 
            this.update_user.Location = new System.Drawing.Point(332, 315);
            this.update_user.Name = "update_user";
            this.update_user.Size = new System.Drawing.Size(147, 44);
            this.update_user.TabIndex = 4;
            this.update_user.Text = "Update User";
            this.update_user.UseVisualStyleBackColor = true;
            this.update_user.Click += new System.EventHandler(this.update_user_Click);
            // 
            // old_user_input
            // 
            this.old_user_input.Location = new System.Drawing.Point(304, 51);
            this.old_user_input.Name = "old_user_input";
            this.old_user_input.Size = new System.Drawing.Size(201, 22);
            this.old_user_input.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Old Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.old_user_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.update_user);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button update_user;
        private System.Windows.Forms.TextBox old_user_input;
        private System.Windows.Forms.Label label1;
    }
}