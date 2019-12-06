namespace Odev2
{
    partial class rchListele
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
            this.rchListele2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchListele2
            // 
            this.rchListele2.Location = new System.Drawing.Point(60, 69);
            this.rchListele2.Name = "rchListele2";
            this.rchListele2.Size = new System.Drawing.Size(157, 133);
            this.rchListele2.TabIndex = 0;
            this.rchListele2.Text = "";
            // 
            // rchListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rchListele2);
            this.Name = "rchListele";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchListele2;
    }
}