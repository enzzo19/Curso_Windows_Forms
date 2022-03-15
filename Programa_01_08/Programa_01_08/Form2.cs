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
    public partial class Form2 : Form
    {
        private string comentario;
        public Form2(string p_message)
        {
            InitializeComponent();
            lbl_messsage.Text = p_message;
        }

        public string Comentario
        {
            set
            {
                comentario = value;
                lbl_comment.Text = comentario;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
