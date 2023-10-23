namespace web_service
{
    partial class DeleteUserForm
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
            this.old_user_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // old_user_input
            // 
            this.old_user_input.Location = new System.Drawing.Point(351, 130);
            this.old_user_input.Name = "old_user_input";
            this.old_user_input.Size = new System.Drawing.Size(201, 22);
            this.old_user_input.TabIndex = 17;
            this.old_user_input.TextChanged += new System.EventHandler(this.old_user_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(379, 190);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(147, 44);
            this.delete_user.TabIndex = 11;
            this.delete_user.Text = "Delete User";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.old_user_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_user);
            this.Name = "DeleteUserForm";
            this.Text = "DeleteUserForm";
            this.Load += new System.EventHandler(this.DeleteUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox old_user_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_user;
    }
}