using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_message.Text = "";
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (chk_monitor.Checked == true)
                total = total + 250;
            if (chk_teclado.Checked == true)
                total = total + 15;
            if (chk_mousse.Checked == true)
                total = total + 20;
            
            // Esto es una ventana emergente
            // MessageBox.Show("El total es: " + total.ToString());


        }

        private void chk_monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_monitor.Checked == true)
                lbl_message.Text = "Monitor";
            else
                lbl_message.Text = "";
        }
    }
}
