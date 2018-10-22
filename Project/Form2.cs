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
    public partial class Form2 : Form
    {
        public Form4 menu;
        public Form5 step;
        SqlConnection db = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        SqlConnection db2 = new SqlConnection();
        SqlCommand cmd2 = new SqlCommand();

        SqlDataReader reader;
        public int id;
        string tmp;
        int num, width, height, time, time2;
        string[] date;
        Button[] btn;

        public Form2(Form4 menu, Form5 step)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.menu = menu;
            this.step = step;
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            id = int.Parse(step.textBox1.Text);
            //timer1.Start();
            //MessageBox.Show(id.ToString(), id.ToString(), MessageBoxButtons.OK);
            db.ConnectionString = @"Data Source=(LocalDB)\v11.0;" + "AttachDbFilename=|DataDirectory|Database2.mdf;" + "Integrated Security=True";
            db.Open();
            cmd.Connection = db;
            cmd.CommandText = @"SELECT * FROM [Table] WHERE Id ='" + id + "'";
            reader = cmd.ExecuteReader();
            reader.Read();

            num = reader.GetInt32(7);
            
            width = 370 / num;
            time = int.Parse(reader.GetString(4).Substring(0, 2)) - int.Parse(reader.GetString(3).Substring(0, 2));
            height = 275 / time;
            time2 = int.Parse(reader.GetString(3).Substring(0, 2));

            btn = new Button[time * reader.GetInt32(7)];

            string tmp = reader.GetString(2);
            date = tmp.Split(' ');

            for (int i = 0; i < num; i++)
            {
                //width
                for (int j = 0; j < time; j++)
                {
                    //height
                    btn[j + time * i] = new Button();
                    btn[j + time * i].FlatStyle = FlatStyle.Flat;
                    btn[j + time * i].Click += btn_mouseClick;
                    toolTip1.SetToolTip(btn[j+time*i],date[i+1]);
                    groupBox1.Controls.Add(btn[j + time * i]);
                    btn[j + time * i].SetBounds(0 + width * i, 15 + height * j, width, height);
                    if (time2 + 1 <= int.Parse(reader.GetString(4).Substring(0, 2)))
                    {
                        time2 = time2 + 1;
                        btn[j + time * i].Text = (time2 - 1) + ":00 ~ " + time2 + ":00";
                    }
                    else
                    {
                        time2 = int.Parse(reader.GetString(3).Substring(0, 2));
                        time2 = time2 + 1;
                        btn[j + time * i].Text = (time2 - 1) + ":00 ~ " + time2 + ":00";
                    }

                }
            }
            reader.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            menu.Show();

        }

        public void btn_mouseClick(object sender, EventArgs e)
        {
            Button clk = (Button)sender;
            if (clk.BackColor == Color.DeepSkyBlue)
            {
                clk.BackColor = default(Color);
            }
            else
            {
                clk.BackColor = Color.DeepSkyBlue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = date[2] + date[1];

            db2.ConnectionString = @"Data Source=(LocalDB)\v11.0;" + "AttachDbFilename=|DataDirectory|Database2.mdf;" + "Integrated Security=True";
            db2.Open();

            cmd2.Connection = db2;

            for (int i = 0; i < num; i++)
            {
                //width  m
                for (int j = 0; j < time; j++)
                {
                    //height
                    if (btn[j + time * i].BackColor == Color.DeepSkyBlue)
                    {
                        //MessageBox.Show(date[i+1], date[i+1], MessageBoxButtons.OK);
                        tmp = tmp + btn[j + time * i].Text+"/";
                        
                    }

                }
                // cmd.Connection.Open();
            }
            cmd2.CommandText = @"INSERT INTO [Table1](Id,Name,Time,Reason)VALUES('" + id + "',N'" + textBox1.Text.Replace("'", "''") + "','" + (tmp + "/") + "',N'" + textBox2.Text.Replace("'", "''") + "')";

            cmd2.ExecuteNonQuery();
            cmd2.CommandText = @"SELECT * FROM [Table1] WHERE Id ='" + id + "'";
            reader = cmd2.ExecuteReader();
            reader.Read();
            MessageBox.Show(reader.GetString(2), reader.GetInt32(0).ToString(), MessageBoxButtons.OK);
            db2.Close();

            this.Hide();
            menu.Show();
        }

        private void button_Hover(object sender, EventArgs e)
        {


        }
    }
}
