using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form5 : Form
    {
        public Form4 menu;
        public Form2 vote;
        public Form3 check;
        public Form5(Form4 menu)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.menu = menu;
            vote = new Form2(menu,this);
            check = new Form3(menu,this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Visible = false;
            pictureBox2.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button3, "Test");
            toolTip1.ShowAlways = true;
            pictureBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            e.Cancel = true;
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            //vote.Show();
            //vote.id = int.Parse(this.textBox1.Text);
            new Form2(menu,this).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            check.Show();
            this.Hide();
        }
    }
}
