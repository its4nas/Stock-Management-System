using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using web_service.Stocks_Form;
using web_service.Transaction_Form;

namespace web_service
{
    public partial class Form2 : Form
    {
        private UserForm u;
        private ItemForm i;
        private StocksForm s;
        private TransactionForm t;
        private TForm v;

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

        private void button1_Click(object sender, EventArgs e)
        {
            s = new StocksForm();
            s.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(s); // Add UserForm to panel2's Controls collection
            s.Dock = DockStyle.Fill; // Dock UserForm within panel2
            s.Show(); // Show UserForm

        }

        private void transaction_Click(object sender, EventArgs e)
        {
            t = new TransactionForm();
            t.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(t); // Add UserForm to panel2's Controls collection
            t.Dock = DockStyle.Fill; // Dock UserForm within panel2
            t.Show(); // Show UserForm
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            v = new TForm();
            v.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(v); // Add UserForm to panel2's Controls collection
            v.Dock = DockStyle.Fill; // Dock UserForm within panel2
            v.Show();
        }
    }
}