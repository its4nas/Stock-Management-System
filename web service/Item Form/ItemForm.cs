using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using web_service.Item_Form;

namespace web_service
{
    public partial class ItemForm : Form
    {
        public class Items
        {
            public Items(string name, string id)
            {
                this.id = id;
                this.name = name;
                
            }
            public string id { set; get; }
            public string name { set; get; }
            

        }
        public ItemForm()
        {
            InitializeComponent();
        }

        string url = "http://localhost:8080/programming_adv/index.php";
        /*void webservices(string data)
        {

            WebRequest RE = WebRequest.Create(url);
            RE.Method = "post";
            RE.ContentType = "application/x-www-form-urlencoded";
            Stream st = RE.GetRequestStream();
            Byte[] bt = Encoding.UTF8.GetBytes(data);
            st.Write(bt, 0, bt.Length);

            WebResponse res = RE.GetResponse();
            st = res.GetResponseStream();
            StreamReader str = new StreamReader(st);

            List<Items> user_info = new List<Items>();
            foreach (string row in str.ReadToEnd().Split('#'))
            {
                try
                {
                    user_info.Add(new Items(row.Split(',')[0], row.Split(',')[1]));
                }
                catch { }
            }
            dataGridView1.DataSource = user_info;
        }*/



        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateItemForm i = new UpdateItemForm();
            i.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(i); // Add UserForm to panel2's Controls collection
            i.Dock = DockStyle.Fill; // Dock UserForm within panel2
            i.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteItemForm i = new DeleteItemForm();
            i.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(i); // Add UserForm to panel2's Controls collection
            i.Dock = DockStyle.Fill; // Dock UserForm within panel2
            i.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddItemForm i = new AddItemForm();


            i.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(i); // Add UserForm to panel2's Controls collection
            i.Dock = DockStyle.Fill; // Dock UserForm within panel2
            i.Show(); // Show 
        }
        void webservices_items(string data)
        {

            WebRequest RE = WebRequest.Create(url);
            RE.Method = "post";
            RE.ContentType = "application/x-www-form-urlencoded";
            Stream st = RE.GetRequestStream();
            Byte[] bt = Encoding.UTF8.GetBytes(data);
            st.Write(bt, 0, bt.Length);

            WebResponse res = RE.GetResponse();
            st = res.GetResponseStream();
            StreamReader str = new StreamReader(st);

            List<Items> item_info = new List<Items>();
            foreach (string row in str.ReadToEnd().Split('#'))
            {
                try
                {
                    item_info.Add(new Items(row.Split(',')[1] , row.Split(',')[0]));
                }
                catch { }
            }
            dataGridView1.DataSource = item_info;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void showallusers_Click_1(object sender, EventArgs e)
        {
            webservices_items("showallitems=''");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
