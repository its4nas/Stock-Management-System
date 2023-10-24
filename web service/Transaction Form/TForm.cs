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

namespace web_service.Transaction_Form
{
    public partial class TForm : Form
    {
        public class Transaction
        {
            public Transaction(string id, string storeId, string productId, int quantity, string transactionType, DateTime transactionDate)
            {
                Id = id;
                StoreId = storeId;
                ProductId = productId;
                Quantity = quantity;
                TransactionType = transactionType;
                TransactionDate = transactionDate;
            }

            public string Id { get; set; }
            public string StoreId { get; set; }
            public string ProductId { get; set; }
            public int Quantity { get; set; }
            public string TransactionType { get; set; }
            public DateTime TransactionDate { get; set; }
        }

        public TForm()
        {
            InitializeComponent();
        }

        string url = "http://localhost:8080/programming_adv/Transitions.php";
        void webservices_T(string data)
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

            List<Transaction> item_info = new List<Transaction>();
            foreach (string row in str.ReadToEnd().Split('#'))
            {
                try
                {
                    string[] splitRow = row.Split(',');

                    int value2 = int.Parse(splitRow[2]);
                    DateTime value0 = DateTime.Parse(splitRow[0]);
                    item_info.Add(new Transaction(row.Split(',')[5], row.Split(',')[4], row.Split(',')[3], value2, row.Split(',')[1], value0));
                }
                catch { }
            }
            dataGridView1.DataSource = item_info;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
