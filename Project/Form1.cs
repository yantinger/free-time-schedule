using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        Form4 menu;
        SqlConnection db = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string date;

        public Form1(Form4 menu)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.menu = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入標題", "錯誤", MessageBoxButtons.OK);
            }
            else if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("請選擇日期", "錯誤", MessageBoxButtons.OK);
            }
            else if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("請選擇時間", "錯誤", MessageBoxButtons.OK);
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("請選擇時間間隔", "錯誤", MessageBoxButtons.OK);
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("請勾選Yes/No", "錯誤", MessageBoxButtons.OK);
            }
            else
            {
                int ans;

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    date = date + " " + checkedListBox1.Items[i];
                }
                if (radioButton1.Checked)
                {
                    ans = 1;
                }
                else
                {
                    ans = 0;
                }

                try
                {
                    db.Open();
                    cmd.Connection = db;
                    cmd.CommandText = @"SELECT TOP 1 * FROM [Table] ORDER BY Id DESC";
                    int id;
                    id = int.Parse(cmd.ExecuteScalar().ToString());
                    id++;
                    MessageBox.Show("表單序號：" + id.ToString(), "表單序號", MessageBoxButtons.OK);

                    cmd.CommandText = @"INSERT INTO [Table](Id,Title,Date,Time1,Time2,Gap,Reason,Num)VALUES('" + id + "',N'" + textBox1.Text.Replace("'", "''") + "',N'" + date.Replace("'", "''") + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + ans + "'," + checkedListBox1.Items.Count + ")";

                    cmd.ExecuteNonQuery();
                    db.Close();
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // label5.Text = ""+dateTimePicker1.Text;
            checkedListBox1.Items.Add(dateTimePicker1.Text, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count != 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        checkedListBox1.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            menu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'database2DataSet2.Table' 資料表。您可以視需要進行移動或移除。
            this.tableTableAdapter.Fill(this.database2DataSet2.Table);
            db.ConnectionString = @"Data Source=(LocalDB)\v11.0;" + "AttachDbFilename=|DataDirectory|Database2.mdf;" + "Integrated Security=True";
            date = "";
        }
    }
}
