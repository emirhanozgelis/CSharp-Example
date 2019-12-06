namespace Odev2
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
            this.btnKayitEkleme = new System.Windows.Forms.Button();
            this.btnKayitListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKayitEkleme
            // 
            this.btnKayitEkleme.BackColor = System.Drawing.Color.Black;
            this.btnKayitEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitEkleme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKayitEkleme.Location = new System.Drawing.Point(85, 43);
            this.btnKayitEkleme.Name = "btnKayitEkleme";
            this.btnKayitEkleme.Size = new System.Drawing.Size(209, 72);
            this.btnKayitEkleme.TabIndex = 0;
            this.btnKayitEkleme.Text = "Kayıt Ekleme";
            this.btnKayitEkleme.UseVisualStyleBackColor = false;
            this.btnKayitEkleme.Click += new System.EventHandler(this.btnKayitEkleme_Click);
            // 
            // btnKayitListele
            // 
            this.btnKayitListele.BackColor = System.Drawing.Color.Black;
            this.btnKayitListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitListele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKayitListele.Location = new System.Drawing.Point(85, 143);
            this.btnKayitListele.Name = "btnKayitListele";
            this.btnKayitListele.Size = new System.Drawing.Size(209, 72);
            this.btnKayitListele.TabIndex = 1;
            this.btnKayitListele.Text = "Kayıt Listele";
            this.btnKayitListele.UseVisualStyleBackColor = false;
            this.btnKayitListele.Click += new System.EventHandler(this.btnKayitListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.btnKayitListele);
            this.Controls.Add(this.btnKayitEkleme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayitEkleme;
        private System.Windows.Forms.Button btnKayitListele;
    }
}

