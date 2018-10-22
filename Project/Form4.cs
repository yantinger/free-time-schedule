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
    public partial class Form4 : Form
    {
        public Form1 createForm;
        public Form5 findForm;
        public Form4()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            createForm = new Form1(this);
            findForm = new Form5(this);
    }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1
            createForm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form5
            findForm.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
