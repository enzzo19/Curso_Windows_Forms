
namespace Programa_01_03
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
            this.lbl_a = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_multiplicaion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(32, 36);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(20, 13);
            this.lbl_a.TabIndex = 0;
            this.lbl_a.Text = "A: ";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(59, 36);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 1;
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(32, 75);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(17, 13);
            this.lbl_b.TabIndex = 2;
            this.lbl_b.Text = "B:";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(59, 75);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 3;
            this.txt_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(124, 114);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "label1";
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(180, 36);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(50, 25);
            this.btn_suma.TabIndex = 5;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(180, 75);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(50, 25);
            this.btn_resta.TabIndex = 6;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(236, 75);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(50, 25);
            this.btn_division.TabIndex = 8;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_multiplicaion
            // 
            this.btn_multiplicaion.Location = new System.Drawing.Point(236, 36);
            this.btn_multiplicaion.Name = "btn_multiplicaion";
            this.btn_multiplicaion.Size = new System.Drawing.Size(50, 25);
            this.btn_multiplicaion.TabIndex = 7;
            this.btn_multiplicaion.Text = "*";
            this.btn_multiplicaion.UseVisualStyleBackColor = true;
            this.btn_multiplicaion.Click += new System.EventHandler(this.btn_multiplicaion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 147);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplicaion);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lbl_a);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_multiplicaion;
    }
}

