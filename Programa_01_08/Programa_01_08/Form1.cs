using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_08
{
    public partial class Form1 : Form
    {
        // Creamos la instancia de la Forma 2
        Form2 mi_forma_2 = new Form2("Saludos");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_envio_Click(object sender, EventArgs e)
        {
            mi_forma_2.Comentario = txt_message.Text; // mensaje enviado via parametro

            //Mostramos la Forma 2
            //mi_forma_2.ShowDialog();
            mi_forma_2.Show();
        }

        private void btn_envio_2_Click(object sender, EventArgs e)
        {
            mi_forma_2.Comentario = txt_message.Text;

        }
    }
}
