using Newtonsoft.Json;
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

namespace web_service
{
    public partial class UserForm : Form
    {
        public class Users
        {
            public Users(string id, string name, string pass)
            {
                this.id = id;
                this.name = name;
                this.pass = pass;
            }
            public string id {set;get;}
            public string name { set; get; }
            public string pass { set; get; }
        }
        public UserForm()
        {
            InitializeComponent();
        }

        string url = "http://localhost:8080/programming_adv/index.php";
        void webservices(string data)
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

            List<Users> user_info = new List<Users>();
            foreach (string row in str.ReadToEnd().Split('#'))
            {
                try
                {
                    user_info.Add(new Users(row.Split(',')[0], row.Split(',')[1], row.Split(',')[2]));
                }
                catch { }
            }
            dataGridView1.DataSource = user_info;
        }

        //void webservices(string data)
        //{
        //    WebRequest RE = WebRequest.Create("http://localhost:8080/programming_adv/index.php");
        //    RE.Method = "post";
        //    RE.ContentType = "application/x-www-form-urlencoded";
        //    Stream st = RE.GetRequestStream();

        //    Byte[] bt = Encoding.UTF8.GetBytes(data);
        //    st.Write(bt, 0, bt.Length);

        //    WebResponse res = RE.GetResponse();
        //    st = res.GetResponseStream();

        //    StreamReader sr = new StreamReader(st);

        //    string jsonResponse = sr.ReadToEnd();

        //    // Parse the JSON response
        //    List<Users> user_info = new List<Users>();
        //    try
        //    {
        //        dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);
        //        foreach (dynamic item in responseObject)
        //        {
        //            string id = item.id.ToString();
        //            string name = item.name.ToString();
        //            user_info.Add(new Users(id, name, ""));
        //        }
        //    }
        //    catch { }

        //    dataGridView1.DataSource = user_info;
        //}

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateUserForm u = new UpdateUserForm();
            u.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(u); // Add UserForm to panel2's Controls collection
            u.Dock = DockStyle.Fill; // Dock UserForm within panel2
            u.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DeleteUserForm u = new DeleteUserForm();
            u.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(u); // Add UserForm to panel2's Controls collection
            u.Dock = DockStyle.Fill; // Dock UserForm within panel2
            u.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddUserForm u = new AddUserForm();
         

            u.TopLevel = false; // Set TopLevel property to false
            panel2.Controls.Clear(); // Clear any existing controls in panel2
            panel2.Controls.Add(u); // Add UserForm to panel2's Controls collection
            u.Dock = DockStyle.Fill; // Dock UserForm within panel2
            u.Show(); // Show 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void showallusers_Click_1(object sender, EventArgs e)
        {
            webservices("showallusers=''");
        }
    }
}
