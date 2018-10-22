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
    public partial class Form3 : Form
    {
        public Form4 menu;
        public Form5 step;

        SqlConnection db = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public int id;
        string[] date;
        int num, width, height, time, time2;
        Button[] btn;
        public Form3(Form4 menu, Form5 step)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.menu = menu;
            this.step = step;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            menu.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            id = int.Parse(step.textBox1.Text);
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
                    //btn[j + time * i].Click += btn_mouseClick;
                    toolTip1.SetToolTip(btn[j + time * i], date[i + 1]);
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

        }
    }
}
