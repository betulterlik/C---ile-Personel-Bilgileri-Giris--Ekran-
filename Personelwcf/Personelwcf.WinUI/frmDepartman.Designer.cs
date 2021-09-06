namespace Personelwcf.WinUI
{
    partial class frmDepartman
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
            this.lblGeriDon = new System.Windows.Forms.LinkLabel();
            this.btnDepartmanSil = new System.Windows.Forms.Button();
            this.dgvDeparmanlistele = new System.Windows.Forms.DataGridView();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeparmanlistele)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGeriDon
            // 
            this.lblGeriDon.AutoSize = true;
            this.lblGeriDon.Location = new System.Drawing.Point(12, 85);
            this.lblGeriDon.Name = "lblGeriDon";
            this.lblGeriDon.Size = new System.Drawing.Size(49, 13);
            this.lblGeriDon.TabIndex = 11;
            this.lblGeriDon.TabStop = true;
            this.lblGeriDon.Text = "Geri Dön";
            this.lblGeriDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGeriDon_LinkClicked);
            // 
            // btnDepartmanSil
            // 
            this.btnDepartmanSil.Location = new System.Drawing.Point(184, 56);
            this.btnDepartmanSil.Name = "btnDepartmanSil";
            this.btnDepartmanSil.Size = new System.Drawing.Size(71, 23);
            this.btnDepartmanSil.TabIndex = 10;
            this.btnDepartmanSil.Text = "Sil";
            this.btnDepartmanSil.UseVisualStyleBackColor = true;
            this.btnDepartmanSil.Click += new System.EventHandler(this.btnDepartmanSil_Click);
            // 
            // dgvDeparmanlistele
            // 
            this.dgvDeparmanlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeparmanlistele.Location = new System.Drawing.Point(15, 114);
            this.dgvDeparmanlistele.Name = "dgvDeparmanlistele";
            this.dgvDeparmanlistele.Size = new System.Drawing.Size(619, 183);
            this.dgvDeparmanlistele.TabIndex = 9;
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.Location = new System.Drawing.Point(107, 56);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(71, 23);
            this.btnDepartmanEkle.TabIndex = 8;
            this.btnDepartmanEkle.Text = "Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Departman Adi";
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(107, 15);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(157, 20);
            this.txtDepartman.TabIndex = 6;
            // 
            // frmDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 314);
            this.Controls.Add(this.lblGeriDon);
            this.Controls.Add(this.btnDepartmanSil);
            this.Controls.Add(this.dgvDeparmanlistele);
            this.Controls.Add(this.btnDepartmanEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartman);
            this.Name = "frmDepartman";
            this.Text = "frmDepartman";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeparmanlistele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblGeriDon;
        private System.Windows.Forms.Button btnDepartmanSil;
        private System.Windows.Forms.DataGridView dgvDeparmanlistele;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartman;
    }
}