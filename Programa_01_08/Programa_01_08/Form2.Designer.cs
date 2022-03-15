
namespace Programa_01_08
{
    partial class Form2
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
            this.lbl_messsage = new System.Windows.Forms.Label();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_messsage
            // 
            this.lbl_messsage.AutoSize = true;
            this.lbl_messsage.Location = new System.Drawing.Point(51, 32);
            this.lbl_messsage.Name = "lbl_messsage";
            this.lbl_messsage.Size = new System.Drawing.Size(35, 13);
            this.lbl_messsage.TabIndex = 0;
            this.lbl_messsage.Text = "label1";
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Location = new System.Drawing.Point(51, 81);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(35, 13);
            this.lbl_comment.TabIndex = 1;
            this.lbl_comment.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 204);
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.lbl_messsage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_messsage;
        private System.Windows.Forms.Label lbl_comment;
    }
}