using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double resultado = a + b;

            lbl_resultado.Text = Convert.ToString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            txt_a.Text = "0";
            txt_b.Text = "0";
        }

        private void btn_multiplicaion_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double resultado = a * b;

            lbl_resultado.Text = Convert.ToString(resultado);
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double resultado = a - b;

            lbl_resultado.Text = Convert.ToString(resultado);
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double resultado = a / b;

            lbl_resultado.Text = Convert.ToString(resultado);
        }
    }
}
