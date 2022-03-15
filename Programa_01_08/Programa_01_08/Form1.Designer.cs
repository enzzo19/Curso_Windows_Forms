
namespace Programa_01_08
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
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_envio_1 = new System.Windows.Forms.Button();
            this.btn_envio_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(12, 28);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(100, 20);
            this.txt_message.TabIndex = 0;
            // 
            // btn_envio_1
            // 
            this.btn_envio_1.Location = new System.Drawing.Point(197, 24);
            this.btn_envio_1.Name = "btn_envio_1";
            this.btn_envio_1.Size = new System.Drawing.Size(75, 23);
            this.btn_envio_1.TabIndex = 1;
            this.btn_envio_1.Text = "Envio_1";
            this.btn_envio_1.UseVisualStyleBackColor = true;
            this.btn_envio_1.Click += new System.EventHandler(this.btn_envio_Click);
            // 
            // btn_envio_2
            // 
            this.btn_envio_2.Location = new System.Drawing.Point(197, 79);
            this.btn_envio_2.Name = "btn_envio_2";
            this.btn_envio_2.Size = new System.Drawing.Size(75, 23);
            this.btn_envio_2.TabIndex = 2;
            this.btn_envio_2.Text = "Envio_2";
            this.btn_envio_2.UseVisualStyleBackColor = true;
            this.btn_envio_2.Click += new System.EventHandler(this.btn_envio_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 197);
            this.Controls.Add(this.btn_envio_2);
            this.Controls.Add(this.btn_envio_1);
            this.Controls.Add(this.txt_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_envio_1;
        private System.Windows.Forms.Button btn_envio_2;
    }
}

