using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#5A5A5A");
            ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            button1.BackColor = ColorTranslator.FromHtml("#FD0002");
            button2.BackColor = ColorTranslator.FromHtml("#FD0002");
            button3.BackColor = ColorTranslator.FromHtml("#FD0002");
            textBox1.ForeColor = ColorTranslator.FromHtml("#222222");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = textBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = textBox1.Text;
        }
        private void button1_Down(object sender, MouseEventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#AE0A13");
        }
        private void button2_Down(object sender, MouseEventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#AE0A13");
        }
        private void button3_Down(object sender, MouseEventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#AE0A13");
        }
        private void button1_Up(object sender, MouseEventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#FD0002");
        }
        private void button2_Up(object sender, MouseEventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FD0002");
        }
        private void button3_Up(object sender, MouseEventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#FD0002");
        }
    }
}
