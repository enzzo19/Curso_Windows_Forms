using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_a.Text = "0";
            txt_b.Text = "0";
            lbl_resultado.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double resultado = 0.0;
            double a = 0.0;
            double b = 0.0;

            a = Convert.ToDouble(txt_a.Text);
            b = Convert.ToDouble(txt_b.Text);

            if (rb_suma.Checked == true)
                resultado = a + b;
            if (rb_resta.Checked == true)
                resultado = a - b;
            if (rb_multi.Checked == true)
                resultado = a * b;
            if (rb_div.Checked == true)
                resultado = a / b;

            lbl_resultado.Text = resultado.ToString();
        }
    }
}
