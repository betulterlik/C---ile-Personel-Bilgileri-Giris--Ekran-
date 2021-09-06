namespace Personelwcf.WinUI
{
    partial class frmPersonelListele
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
            this.lnkGeriDon = new System.Windows.Forms.LinkLabel();
            this.dgvPersonelListele = new System.Windows.Forms.DataGridView();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkGeriDon
            // 
            this.lnkGeriDon.AutoSize = true;
            this.lnkGeriDon.Location = new System.Drawing.Point(27, 24);
            this.lnkGeriDon.Name = "lnkGeriDon";
            this.lnkGeriDon.Size = new System.Drawing.Size(49, 13);
            this.lnkGeriDon.TabIndex = 5;
            this.lnkGeriDon.TabStop = true;
            this.lnkGeriDon.Text = "Geri Dön";
            this.lnkGeriDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGeriDon_LinkClicked);
            // 
            // dgvPersonelListele
            // 
            this.dgvPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListele.Location = new System.Drawing.Point(12, 55);
            this.dgvPersonelListele.Name = "dgvPersonelListele";
            this.dgvPersonelListele.Size = new System.Drawing.Size(1263, 349);
            this.dgvPersonelListele.TabIndex = 4;
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(289, 12);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(733, 37);
            this.btnPersonelListele.TabIndex = 3;
            this.btnPersonelListele.Text = "Personelleri Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 407);
            this.Controls.Add(this.lnkGeriDon);
            this.Controls.Add(this.dgvPersonelListele);
            this.Controls.Add(this.btnPersonelListele);
            this.Name = "frmPersonelListele";
            this.Text = "frmPersonelListele";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkGeriDon;
        private System.Windows.Forms.DataGridView dgvPersonelListele;
        private System.Windows.Forms.Button btnPersonelListele;
    }
}