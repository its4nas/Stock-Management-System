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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {
            UserForm u = new UserForm();
            panel2.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }
    }
}
