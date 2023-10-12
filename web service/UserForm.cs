using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_service
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }



        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateUserForm u = new UpdateUserForm();
            panel2.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteUserForm u = new DeleteUserForm();
            panel2.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddUserForm u = new AddUserForm();
            panel2.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }
    }
}
