using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_01_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            // 1_solo con un texto
            //MessageBox.Show("Hola a Todos :)");

            // 2_ con texto y titulo en la ventana
            // MessageBox.Show("Hola a Todos :)",
            //                 "Mi messageBox");

            // 3_ mensaje - titulo en ventana - botones
            // MessageBox.Show("Probamos Botones",
            //                 "Diferentes Botones",
            //                 MessageBoxButtons.AbortRetryIgnore);

            // 4_ mensaje - titulo en ventana - botones - iconos
            MessageBox.Show("Probamos Botones",
                            "Diferentes Botones",
                            MessageBoxButtons.AbortRetryIgnore,
                            MessageBoxIcon.Warning);

            // Capturando lo que devuelve messagebox en una variable
            DialogResult resultado = MessageBox.Show("Probamos Botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore);

            // Tomando una decision basandonos en el resultado
            if (resultado == DialogResult.Abort)
                lbl_message.Text = "Omitir";
            if (resultado == DialogResult.Retry)
                lbl_message.Text = "Reintentar";
            if (resultado == DialogResult.Ignore)
                lbl_message.Text = "Ignorar";

        }
    }
}
