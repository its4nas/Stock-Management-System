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
    public partial class TransactionForm : Form
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
        public TransactionForm()
        {
            InitializeComponent();
            
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        string url = "http://localhost:8080/programming_adv/Transitions.php";

        //void webservicesItem(string data)
        //{

        //    WebRequest RE = WebRequest.Create(url);
        //    RE.Method = "post";
        //    RE.ContentType = "application/x-www-form-urlencoded";
        //    Stream st = RE.GetRequestStream();
        //    Byte[] bt = Encoding.UTF8.GetBytes(data);
        //    st.Write(bt, 0, bt.Length);

        //    WebResponse res = RE.GetResponse();
        //    st = res.GetResponseStream();
        //    StreamReader str = new StreamReader(st);
        //}



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
            int SumIn = 0;
            int SumOut = 0;

            List<Transaction> user_info = new List<Transaction>();
            user_info.Clear();
            foreach (string row in str.ReadToEnd().Split('#'))
            {
                try
                {
                    string[] rowData = row.Split(',');
                    if (rowData.Length == 6)
                    {
                        string id = rowData[0];
                        string storeId = rowData[1];
                        string productId = rowData[2];
                        int quantity = 0;
                        int.TryParse(rowData[3], out quantity); // Convert to int

                        string transactionType = rowData[4];
                        DateTime transactionDate = DateTime.Parse(rowData[5]);
                        if (transactionType == "IN")
                        {
                            SumIn += quantity;
                        }
                        else if (transactionType == "OUT")
                        {
                            SumOut += quantity;
                        }
                        user_info.Add(new Transaction(id, storeId, productId, quantity,
                            transactionType, transactionDate));
                    }


                }
                catch { }
            }

            textBox3.Text = SumIn.ToString();
            textBox4.Text = SumOut.ToString();

            dataGridView1.DataSource = user_info;
        }

        private string PopulateComboBox(string data, string selectedValue)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            using (Stream stream = request.GetRequestStream())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                stream.Write(bytes, 0, bytes.Length);
            }

            using (WebResponse response = request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string responseText = reader.ReadToEnd();
                Dictionary<string, string> itemList = new Dictionary<string, string>();

                foreach (string row in responseText.Split('#'))
                {
                    try
                    {
                        string[] parts = row.Split(',');
                        if (parts.Length == 2)
                        {
                            string key = parts[0];
                            string value = parts[1];
                            itemList.Add(key, value);
                        }
                    }
                    catch { }
                }




                // Store the currently selected value
                comboBox1.DataSource = new BindingSource(itemList, null);

                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                if (!string.IsNullOrEmpty(selectedValue))
                    comboBox1.SelectedValue = selectedValue;

                return comboBox1.SelectedValue?.ToString();
            }
        }


        private string PopulateComboBox2(string data, string selectedValue)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            using (Stream stream = request.GetRequestStream())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                stream.Write(bytes, 0, bytes.Length);
            }

            using (WebResponse response = request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string responseText = reader.ReadToEnd();
                Dictionary<string, string> itemList = new Dictionary<string, string>();

                foreach (string row in responseText.Split('#'))
                {
                    try
                    {
                        string[] parts = row.Split(',');
                        if (parts.Length == 2)
                        {
                            string key = parts[0];
                            string value = parts[1];
                            itemList.Add(key, value);
                        }
                    }
                    catch { }
                }

                // Store the currently selected value
                comboBox2.DataSource = new BindingSource(itemList, null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";
                if (!string.IsNullOrEmpty(selectedValue))
                    comboBox2.SelectedValue = selectedValue;

                return comboBox2.SelectedValue?.ToString();
            }
        }

        private void PopulateComboBox3(Dictionary<string, string> itemList)
        {
            string selectedValue = comboBox3.SelectedValue?.ToString(); // Store the currently selected value
            comboBox3.DataSource = new BindingSource(itemList, null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";

            if (selectedValue != null && itemList.ContainsKey(selectedValue))
            {
                comboBox3.SelectedValue = selectedValue; // Set the selected value if it exists in the new list
            }
            else
            {
                comboBox3.SelectedIndex = 0; // Set the default selection if the previous selected value is not present
            }


        }
        private void LoaddatawithCondition(string pro, string S_ids)
        {
            string value = PopulateComboBox("showallitems=''", pro);


            string strore = PopulateComboBox2("showallstores=''", S_ids);

            string start_date = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string end_date = dateTimePicker4.Value.ToString("yyyy-MM-dd");

            string data = "showalltransactions=1&product_id=" + value + "&store_id=" + strore + "&start_date=" + start_date + "&end_date=" + end_date + "&searchName=" + textBox5.Text;
            webservices(data);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged; // Remove the event handler temporarily

            string selectedValue = comboBox1.SelectedValue?.ToString();
            string selectedValue2 = comboBox2.SelectedValue?.ToString();
            LoaddatawithCondition(selectedValue, selectedValue2);

            //PopulateComboBox(itemList);

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; // Reattach the event handler
        }

        private void Process_ui_Load(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedValue?.ToString();
            string selectedValue2 = comboBox2.SelectedValue?.ToString();

            LoaddatawithCondition(selectedValue, selectedValue2);



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
