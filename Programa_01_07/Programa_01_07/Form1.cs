using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Form2 mi_forma = new Form2();
            // pueden ser abiertas en simultaneo
            mi_forma.ShowDialog();
            // Que no se regresa a la anterior hasta terminar en esta !
            // mi_forma.ShowDialog();

        }
    }
}
