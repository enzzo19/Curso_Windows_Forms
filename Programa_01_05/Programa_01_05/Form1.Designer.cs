
namespace Programa_01_05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.gbox_operaciones = new System.Windows.Forms.GroupBox();
            this.rb_suma = new System.Windows.Forms.RadioButton();
            this.rb_resta = new System.Windows.Forms.RadioButton();
            this.rb_multi = new System.Windows.Forms.RadioButton();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.gbox_operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(12, 23);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 0;
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(12, 61);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 1;
            this.txt_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(172, 23);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // gbox_operaciones
            // 
            this.gbox_operaciones.Controls.Add(this.rb_div);
            this.gbox_operaciones.Controls.Add(this.rb_resta);
            this.gbox_operaciones.Controls.Add(this.rb_multi);
            this.gbox_operaciones.Controls.Add(this.rb_suma);
            this.gbox_operaciones.Location = new System.Drawing.Point(12, 110);
            this.gbox_operaciones.Name = "gbox_operaciones";
            this.gbox_operaciones.Size = new System.Drawing.Size(128, 112);
            this.gbox_operaciones.TabIndex = 3;
            this.gbox_operaciones.TabStop = false;
            this.gbox_operaciones.Text = "Operaciones";
            // 
            // rb_suma
            // 
            this.rb_suma.AutoSize = true;
            this.rb_suma.Checked = true;
            this.rb_suma.Location = new System.Drawing.Point(18, 20);
            this.rb_suma.Name = "rb_suma";
            this.rb_suma.Size = new System.Drawing.Size(52, 17);
            this.rb_suma.TabIndex = 0;
            this.rb_suma.TabStop = true;
            this.rb_suma.Text = "Suma";
            this.rb_suma.UseVisualStyleBackColor = true;
            // 
            // rb_resta
            // 
            this.rb_resta.AutoSize = true;
            this.rb_resta.Location = new System.Drawing.Point(18, 43);
            this.rb_resta.Name = "rb_resta";
            this.rb_resta.Size = new System.Drawing.Size(53, 17);
            this.rb_resta.TabIndex = 3;
            this.rb_resta.Text = "Resta";
            this.rb_resta.UseVisualStyleBackColor = true;
            // 
            // rb_multi
            // 
            this.rb_multi.AutoSize = true;
            this.rb_multi.Location = new System.Drawing.Point(18, 66);
            this.rb_multi.Name = "rb_multi";
            this.rb_multi.Size = new System.Drawing.Size(72, 17);
            this.rb_multi.TabIndex = 2;
            this.rb_multi.Text = "Multiplicar";
            this.rb_multi.UseVisualStyleBackColor = true;
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(18, 89);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(54, 17);
            this.rb_div.TabIndex = 4;
            this.rb_div.Text = "Dividir";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(169, 67);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 248);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.gbox_operaciones);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Name = "Form1";
            this.Text = "Calculadora con RadioButtons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_operaciones.ResumeLayout(false);
            this.gbox_operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox gbox_operaciones;
        private System.Windows.Forms.RadioButton rb_resta;
        private System.Windows.Forms.RadioButton rb_multi;
        private System.Windows.Forms.RadioButton rb_suma;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

