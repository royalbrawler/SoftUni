using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fnum = double.Parse(this.textBox1.Text);
                var secnum = double.Parse(this.textBox2.Text);
                var res = fnum + secnum;

                this.result.Text = res.ToString();
            }
            catch (Exception)
            {
                this.result.Text = "errrereo";
                this.result.ForeColor = Color.Aqua;
                this.result.BackColor = Color.Azure;
            }
            

        }
    }
}
