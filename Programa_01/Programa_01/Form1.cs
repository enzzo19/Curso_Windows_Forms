using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "Hola a Todos :)";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_despedida_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "Chau a Todos :)";
        }

        private void btn_saludo_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "Hola a Todos :)";
        }
    }
}
