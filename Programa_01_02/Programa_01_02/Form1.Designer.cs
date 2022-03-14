
namespace Programa_01_02
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.bnt_saludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(50, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre: ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(81, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(13, 65);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(35, 13);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "label1";
            // 
            // bnt_saludo
            // 
            this.bnt_saludo.Location = new System.Drawing.Point(226, 7);
            this.bnt_saludo.Name = "bnt_saludo";
            this.bnt_saludo.Size = new System.Drawing.Size(75, 23);
            this.bnt_saludo.TabIndex = 3;
            this.bnt_saludo.Text = "Saludo";
            this.bnt_saludo.UseVisualStyleBackColor = true;
            this.bnt_saludo.Click += new System.EventHandler(this.bnt_saludo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 103);
            this.Controls.Add(this.bnt_saludo);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button bnt_saludo;
    }
}

