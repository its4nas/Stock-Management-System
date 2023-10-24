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
using web_service.Stocks_Form;

namespace web_service
{
    public partial class StocksForm : Form
    {
        public class Stocks
        {
            public Stocks(string location, string name, string id)
            {
                this.id = id;
                this.name = name;
                this.location = location;

            }
            public string id { set; get; }
            public string name { set; get; }
            public string location { set; get; }


        }
        public StocksForm()
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


      

       
        void webservices_stocks(string data)
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

            List<Stocks> item_info = new List<Stocks>();
            foreach (string row in str.ReadToEnd().Split('#'))
            {
                try
                {
                    item_info.Add(new Stocks(row.Split(',')[2], row.Split(',')[1], row.Split(',')[0]));
                }
                catch { }
            }
            dataGridView1.DataSource = item_info;
        }

       

        private void StocksForm_Load(object sender, EventArgs e)
        {

        }

        private void add_button_Click_1(object sender, EventArgs e)
        {
            AddStocksForm s = new AddStocksForm();


            s.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(s); // Add UserForm to panel2's Controls collection
            s.Dock = DockStyle.Fill; // Dock UserForm within panel2
            s.Show(); // Show 

        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            UpdateStocksForm s = new UpdateStocksForm();
            s.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(s); // Add UserForm to panel2's Controls collection
            s.Dock = DockStyle.Fill; // Dock UserForm within panel2
            s.Show();
        }
     

        private void delete_button_Click_1(object sender, EventArgs e)
        {
            DeleteStocksForm s = new DeleteStocksForm();
            s.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(s); // Add UserForm to panel2's Controls collection
            s.Dock = DockStyle.Fill; // Dock UserForm within panel2
            s.Show();
        }

        private void showallstocks_Click(object sender, EventArgs e)
        {
            webservices_stocks("showallstocks=''");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
