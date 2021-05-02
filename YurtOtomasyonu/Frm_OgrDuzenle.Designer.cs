namespace YurtOtomasyonu
{
    partial class Frm_OgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OgrDuzenle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskDogumTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.lblOdaAkif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(282, 558);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 51);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rtxtAdres.Location = new System.Drawing.Point(188, 447);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(224, 105);
            this.rtxtAdres.TabIndex = 10;
            this.rtxtAdres.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(116, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "Adres:";
            // 
            // mskVeliTel
            // 
            this.mskVeliTel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskVeliTel.Location = new System.Drawing.Point(188, 411);
            this.mskVeliTel.Mask = "(999) 000-0000";
            this.mskVeliTel.Name = "mskVeliTel";
            this.mskVeliTel.Size = new System.Drawing.Size(224, 30);
            this.mskVeliTel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(64, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Veli Telefon:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(188, 375);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(224, 30);
            this.txtVeliAdSoyad.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Location = new System.Drawing.Point(43, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 46;
            this.label10.Text = "Veli Ad Soyad:";
            // 
            // mskDogumTarih
            // 
            this.mskDogumTarih.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskDogumTarih.Location = new System.Drawing.Point(188, 204);
            this.mskDogumTarih.Mask = "00/00/0000";
            this.mskDogumTarih.Name = "mskDogumTarih";
            this.mskDogumTarih.Size = new System.Drawing.Size(224, 30);
            this.mskDogumTarih.TabIndex = 4;
            this.mskDogumTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(188, 313);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(224, 33);
            this.cmbOdaNo.TabIndex = 7;
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(188, 239);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(224, 33);
            this.cmbBolumler.TabIndex = 5;
            // 
            // mskTC
            // 
            this.mskTC.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskTC.Location = new System.Drawing.Point(188, 133);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(224, 30);
            this.mskTC.TabIndex = 2;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // mskTel
            // 
            this.mskTel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskTel.Location = new System.Drawing.Point(188, 169);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(224, 30);
            this.mskTel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label7.Location = new System.Drawing.Point(101, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Oda No:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtMail.Location = new System.Drawing.Point(188, 277);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(224, 30);
            this.txtMail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Location = new System.Drawing.Point(133, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Öğrenci Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Location = new System.Drawing.Point(60, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Doğum tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(103, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(141, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "TC:";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtOgrSoyad.Location = new System.Drawing.Point(188, 97);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(224, 30);
            this.txtOgrSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtOgrAd.Location = new System.Drawing.Point(188, 61);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(224, 30);
            this.txtOgrAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(70, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtOgrId
            // 
            this.txtOgrId.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtOgrId.Enabled = false;
            this.txtOgrId.Location = new System.Drawing.Point(188, 25);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(224, 30);
            this.txtOgrId.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label12.Location = new System.Drawing.Point(79, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 50;
            this.label12.Text = "Öğrenci Id:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Location = new System.Drawing.Point(188, 558);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(88, 51);
            this.btn_Sil.TabIndex = 51;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // lblOdaAkif
            // 
            this.lblOdaAkif.AutoSize = true;
            this.lblOdaAkif.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblOdaAkif.Location = new System.Drawing.Point(38, 527);
            this.lblOdaAkif.Name = "lblOdaAkif";
            this.lblOdaAkif.Size = new System.Drawing.Size(23, 25);
            this.lblOdaAkif.TabIndex = 52;
            this.lblOdaAkif.Text = "0";
            // 
            // Frm_OgrDuzenle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(483, 621);
            this.Controls.Add(this.lblOdaAkif);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOgrId);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.rtxtAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskVeliTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskDogumTarih);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.cmbBolumler);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_OgrDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci düzenleme oaneli";
            this.Load += new System.EventHandler(this.Frm_OgrDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskVeliTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskDogumTarih;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label lblOdaAkif;
    }
}