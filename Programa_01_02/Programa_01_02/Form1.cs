using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_message.Text = "";
        }

        private void bnt_saludo_Click(object sender, EventArgs e)
        {
            lbl_message.Text = txt_name.Text + " es el nombre, Holaa !! ";
        }
    }
}
