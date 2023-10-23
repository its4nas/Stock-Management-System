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
        private UserForm u;
        private ItemForm i;

        public Form2()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {
            u = new UserForm();
            u.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(u); // Add UserForm to panel2's Controls collection
            u.Dock = DockStyle.Fill; // Dock UserForm within panel2
            u.Show(); // Show UserForm
        }

        private void items_Click(object sender, EventArgs e)
        {
            i = new ItemForm();
            i.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(i); // Add UserForm to panel2's Controls collection
            i.Dock = DockStyle.Fill; // Dock UserForm within panel2
            i.Show(); // Show UserForm

        }
    }
}