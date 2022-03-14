
namespace Programa_01_04
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
            this.chk_monitor = new System.Windows.Forms.CheckBox();
            this.chk_teclado = new System.Windows.Forms.CheckBox();
            this.chk_mousse = new System.Windows.Forms.CheckBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_monitor
            // 
            this.chk_monitor.AutoSize = true;
            this.chk_monitor.Location = new System.Drawing.Point(55, 52);
            this.chk_monitor.Name = "chk_monitor";
            this.chk_monitor.Size = new System.Drawing.Size(88, 17);
            this.chk_monitor.TabIndex = 0;
            this.chk_monitor.Text = "Monitor $250";
            this.chk_monitor.UseVisualStyleBackColor = true;
            this.chk_monitor.CheckedChanged += new System.EventHandler(this.chk_monitor_CheckedChanged);
            // 
            // chk_teclado
            // 
            this.chk_teclado.AutoSize = true;
            this.chk_teclado.Location = new System.Drawing.Point(55, 75);
            this.chk_teclado.Name = "chk_teclado";
            this.chk_teclado.Size = new System.Drawing.Size(86, 17);
            this.chk_teclado.TabIndex = 1;
            this.chk_teclado.Text = "Teclado $15";
            this.chk_teclado.UseVisualStyleBackColor = true;
            // 
            // chk_mousse
            // 
            this.chk_mousse.AutoSize = true;
            this.chk_mousse.Location = new System.Drawing.Point(55, 99);
            this.chk_mousse.Name = "chk_mousse";
            this.chk_mousse.Size = new System.Drawing.Size(84, 17);
            this.chk_mousse.TabIndex = 2;
            this.chk_mousse.Text = "Mousse $20";
            this.chk_mousse.UseVisualStyleBackColor = true;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(22, 139);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(35, 13);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "label1";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(220, 69);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 215);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.chk_mousse);
            this.Controls.Add(this.chk_teclado);
            this.Controls.Add(this.chk_monitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_monitor;
        private System.Windows.Forms.CheckBox chk_teclado;
        private System.Windows.Forms.CheckBox chk_mousse;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_calculate;
    }
}

