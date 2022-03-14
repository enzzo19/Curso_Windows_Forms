
namespace Programa_01
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_despedida = new System.Windows.Forms.Button();
            this.btn_saludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(61, 65);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(35, 13);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "label1";
            this.lbl_message.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_despedida
            // 
            this.btn_despedida.Location = new System.Drawing.Point(190, 124);
            this.btn_despedida.Name = "btn_despedida";
            this.btn_despedida.Size = new System.Drawing.Size(70, 35);
            this.btn_despedida.TabIndex = 2;
            this.btn_despedida.Text = "Despedida";
            this.btn_despedida.UseVisualStyleBackColor = true;
            this.btn_despedida.Click += new System.EventHandler(this.btn_despedida_Click);
            // 
            // btn_saludo
            // 
            this.btn_saludo.Location = new System.Drawing.Point(190, 65);
            this.btn_saludo.Name = "btn_saludo";
            this.btn_saludo.Size = new System.Drawing.Size(70, 35);
            this.btn_saludo.TabIndex = 3;
            this.btn_saludo.Text = "Saludo";
            this.btn_saludo.UseVisualStyleBackColor = true;
            this.btn_saludo.Click += new System.EventHandler(this.btn_saludo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 268);
            this.Controls.Add(this.btn_saludo);
            this.Controls.Add(this.btn_despedida);
            this.Controls.Add(this.lbl_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_despedida;
        private System.Windows.Forms.Button btn_saludo;
    }
}

