namespace YurtOtomasyonu
{
    partial class Frm_OgrKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.mskDogumTarih = new System.Windows.Forms.MaskedTextBox();
            this.mskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtOgrAd.Location = new System.Drawing.Point(167, 32);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(224, 30);
            this.txtOgrAd.TabIndex = 0;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtOgrSoyad.Location = new System.Drawing.Point(167, 68);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(224, 30);
            this.txtOgrSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(82, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(120, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Location = new System.Drawing.Point(39, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doğum tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label7.Location = new System.Drawing.Point(80, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Oda No:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtMail.Location = new System.Drawing.Point(167, 248);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(224, 30);
            this.txtMail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Location = new System.Drawing.Point(112, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mail:";
            // 
            // mskTel
            // 
            this.mskTel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskTel.Location = new System.Drawing.Point(167, 140);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(224, 30);
            this.mskTel.TabIndex = 3;
            // 
            // mskTC
            // 
            this.mskTC.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskTC.Location = new System.Drawing.Point(167, 104);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(224, 30);
            this.mskTC.TabIndex = 2;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(167, 210);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(224, 33);
            this.cmbBolumler.TabIndex = 5;
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(167, 284);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(224, 33);
            this.cmbOdaNo.TabIndex = 7;
            // 
            // mskDogumTarih
            // 
            this.mskDogumTarih.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskDogumTarih.Location = new System.Drawing.Point(167, 175);
            this.mskDogumTarih.Mask = "00/00/0000";
            this.mskDogumTarih.Name = "mskDogumTarih";
            this.mskDogumTarih.Size = new System.Drawing.Size(224, 30);
            this.mskDogumTarih.TabIndex = 4;
            this.mskDogumTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskVeliTel
            // 
            this.mskVeliTel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mskVeliTel.Location = new System.Drawing.Point(167, 382);
            this.mskVeliTel.Mask = "(999) 000-0000";
            this.mskVeliTel.Name = "mskVeliTel";
            this.mskVeliTel.Size = new System.Drawing.Size(224, 30);
            this.mskVeliTel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(43, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Veli Telefon:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(167, 346);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(224, 30);
            this.txtVeliAdSoyad.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Location = new System.Drawing.Point(22, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Veli Ad Soyad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(95, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Adres:";
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rtxtAdres.Location = new System.Drawing.Point(167, 418);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(224, 105);
            this.rtxtAdres.TabIndex = 10;
            this.rtxtAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(201, 529);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(158, 39);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblId.Location = new System.Drawing.Point(22, 498);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 25);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "Null";
            // 
            // Frm_OgrKayit
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(157)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(438, 596);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnKaydet);
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
            this.Name = "Frm_OgrKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt ";
            this.Load += new System.EventHandler(this.Frm_OgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.MaskedTextBox mskDogumTarih;
        private System.Windows.Forms.MaskedTextBox mskVeliTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblId;
    }
}

