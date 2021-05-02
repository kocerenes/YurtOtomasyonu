namespace YurtOtomasyonu
{
    partial class Frm_Bolumler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bolumler));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbEkle = new System.Windows.Forms.PictureBox();
            this.pcbSil = new System.Windows.Forms.PictureBox();
            this.pcbGuncelle = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(181, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 30);
            this.txtId.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(181, 90);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(202, 30);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm Ad:";
            // 
            // pcbEkle
            // 
            this.pcbEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkle.Image")));
            this.pcbEkle.Location = new System.Drawing.Point(111, 144);
            this.pcbEkle.Name = "pcbEkle";
            this.pcbEkle.Size = new System.Drawing.Size(82, 68);
            this.pcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEkle.TabIndex = 4;
            this.pcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEkle, "Bölüm ekle");
            this.pcbEkle.Click += new System.EventHandler(this.pcbEkle_Click);
            // 
            // pcbSil
            // 
            this.pcbSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbSil.Image")));
            this.pcbSil.Location = new System.Drawing.Point(233, 144);
            this.pcbSil.Name = "pcbSil";
            this.pcbSil.Size = new System.Drawing.Size(82, 68);
            this.pcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSil.TabIndex = 5;
            this.pcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbSil, "Bölüm Sil");
            this.pcbSil.Click += new System.EventHandler(this.pcbSil_Click);
            // 
            // pcbGuncelle
            // 
            this.pcbGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pcbGuncelle.Image")));
            this.pcbGuncelle.Location = new System.Drawing.Point(350, 144);
            this.pcbGuncelle.Name = "pcbGuncelle";
            this.pcbGuncelle.Size = new System.Drawing.Size(82, 68);
            this.pcbGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGuncelle.TabIndex = 6;
            this.pcbGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbGuncelle, "Bölüm Güncelle");
            this.pcbGuncelle.Click += new System.EventHandler(this.pcbGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 316);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Frm_Bolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(511, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbGuncelle);
            this.Controls.Add(this.pcbSil);
            this.Controls.Add(this.pcbEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Bolumler";
            this.Text = "Bölüm İşlemleri";
            this.Load += new System.EventHandler(this.Frm_Bolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbEkle;
        private System.Windows.Forms.PictureBox pcbSil;
        private System.Windows.Forms.PictureBox pcbGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}