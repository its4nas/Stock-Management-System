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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        void webservices(String data)
        {
            

            WebRequest RE = WebRequest.Create("http://localhost:8080/programming_adv/index.php");
            RE.Method = "post";
            RE.ContentType = "application/x-www-form-urlencoded";
            Stream st = RE.GetRequestStream();

            Byte[] bt = Encoding.UTF8.GetBytes(data);
            st.Write(bt, 0, bt.Length);

            WebResponse res = RE.GetResponse();
            st = res.GetResponseStream();

            StreamReader sr = new StreamReader(st);
            //Application.Run(new Form2());
            MessageBox.Show(sr.ReadToEnd());
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            string data = "adduser='' & name='" + user_input.Text + "'&password='" + password_input.Text + "'";
            webservices(data);
        }
    }
}
