using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyonu
{
    public partial class Frm_OgrDuzenle : Form
    {
        public Frm_OgrDuzenle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        public string ıd,ad,soyad,tc,telefon,dogum,bolum,mail,odaNo,veliAdSoyad,veliNo,Adres;

        private void _temizle()
        {
            txtOgrId.Text = "";
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            mskTC.Text = "";
            mskTel.Text = "";
            mskDogumTarih.Text = "";
            cmbBolumler.Text = "";
            txtMail.Text = "";
            cmbOdaNo.Text = "";
            txtVeliAdSoyad.Text = "";
            mskVeliTel.Text = "";
            rtxtAdres.Text = "";
            lblOdaAkif.Text = "0";
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult Sil = new DialogResult();
            Sil = MessageBox.Show("Öğrenciyi silmek istediğinizden emin misiniz?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (Sil == DialogResult.Yes)
            {
                if (Convert.ToInt16(lblOdaAkif.Text) > 0)
                {
                    // Öğrenci silme 
                    connection.Open();
                    SqlCommand command = new SqlCommand("delete from Tbl_Ogrenci where OgrId=@p1", connection);
                    command.Parameters.AddWithValue("@p1", txtOgrId.Text);
                    command.ExecuteNonQuery();
                    connection.Close();

                    // oda aktif kontenjan açma
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("Update Tbl_Oda set OdaAktif=OdaAktif-1 where OdaNo=@k1", connection);
                    command1.Parameters.AddWithValue("@k1", cmbOdaNo.Text);
                    command1.ExecuteNonQuery();
                    connection.Close();

                    _temizle();
                }

                else
                {
                    MessageBox.Show("Böyle bir öğrenci bulunmamakta.");
                }
            }

            if (Sil==DialogResult.No)
            {

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update Tbl_Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTc=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where OgrId=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtOgrId.Text);
            command.Parameters.AddWithValue("@p2", txtOgrAd.Text);
            command.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
            command.Parameters.AddWithValue("@p4", mskTC.Text);
            command.Parameters.AddWithValue("@p5", mskTel.Text);
            command.Parameters.AddWithValue("@p6", mskDogumTarih.Text);
            command.Parameters.AddWithValue("@p7", cmbBolumler.Text);
            command.Parameters.AddWithValue("@p8", txtMail.Text);
            command.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
            command.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
            command.Parameters.AddWithValue("@p11", mskVeliTel.Text);
            command.Parameters.AddWithValue("@p12", rtxtAdres.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Değişiklikler başarıyla kaydedildi.");
            //Frm_OgrListesi list = new Frm_OgrListesi();
            //list.Refresh();
            //list.OgrListele();
            
        }

        private void Frm_OgrDuzenle_Load(object sender, EventArgs e)
        {
            
            //cmbodano ya verileri cekme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select OdaNo from Tbl_Oda", connection);
            DataTable dataTable = new DataTable();
            cmbOdaNo.ValueMember = "OdaId";
            cmbOdaNo.DisplayMember = "OdaNo";
            dataAdapter.Fill(dataTable);
            cmbOdaNo.DataSource = dataTable;


            //cmbbolumlere veri cekme
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("Select BolumAd from Tbl_Bolum", connection);
            DataTable dataTable1 = new DataTable();
            cmbBolumler.ValueMember = "BolumId";
            cmbBolumler.DisplayMember = "BolumAd";
            dataAdapter1.Fill(dataTable1);
            cmbBolumler.DataSource = dataTable1;

            txtOgrId.Text = ıd;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTC.Text = tc;
            mskTel.Text = telefon;
            mskDogumTarih.Text = dogum;
            cmbBolumler.Text = bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text = odaNo;
            txtVeliAdSoyad.Text = veliAdSoyad;
            mskVeliTel.Text = veliNo;
            rtxtAdres.Text = Adres;

            //lblodaaktife oda aktif degerini tasıma
            connection.Open();
            SqlCommand command = new SqlCommand("Select OdaAktif from Tbl_Oda where OdaNo=@p1", connection);
            command.Parameters.AddWithValue("@p1", cmbOdaNo.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblOdaAkif.Text = dataReader[0].ToString();
            }
            connection.Close();

        }
    }
}
