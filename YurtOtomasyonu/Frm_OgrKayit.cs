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
    public partial class Frm_OgrKayit : Form
    {
        public Frm_OgrKayit()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void _komut(SqlCommand kmt)
        {
            kmt.Connection.Open();
            kmt.ExecuteNonQuery();
            kmt.Connection.Close();
        }

        private void _temizle()
        {
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            txtVeliAdSoyad.Text = "";
            txtMail.Text = "";
            mskDogumTarih.Text = "";
            mskTC.Text = "";
            mskTel.Text = "";
            mskVeliTel.Text = "";
            cmbBolumler.Text = "";
            cmbOdaNo.Text = "";
            rtxtAdres.Text = "";
        }

        private void Frm_OgrKayit_Load(object sender, EventArgs e)
        {
            //cmbBolumlere veritabanındaki bolümleri cekme işlemi
            connection.Open();
            SqlCommand command = new SqlCommand("Select BolumAd from Tbl_Bolum", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbBolumler.Items.Add(dataReader[0].ToString());
            }
            connection.Close();

            //Boş odaların comboboxa cekilme işlemi
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select OdaNo from Tbl_Oda Where OdaKapasite!=OdaAktif", connection);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                cmbOdaNo.Items.Add(dataReader1[0].ToString());
            }
            connection.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // öğrenci kaydetme komutları
            SqlCommand command = new SqlCommand("Insert into Tbl_Ogrenci (OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connection);
            command.Parameters.AddWithValue("@p1", txtOgrAd.Text);
            command.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
            command.Parameters.AddWithValue("@p3", mskTC.Text);
            command.Parameters.AddWithValue("@p4", mskTel.Text);
            command.Parameters.AddWithValue("@p5", mskDogumTarih.Text);
            command.Parameters.AddWithValue("@p6", cmbBolumler.Text);
            command.Parameters.AddWithValue("@p7", txtMail.Text);
            command.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
            command.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
            command.Parameters.AddWithValue("@p10", mskVeliTel.Text);
            command.Parameters.AddWithValue("@p11", rtxtAdres.Text);
            _komut(command);
            MessageBox.Show("Kaydınız başarıyla yapıldı.");

            // son eklenen Öğrencinin ıd sinin label12 ye ayzdırma komutu
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select OgrId from Tbl_Ogrenci", connection);
            SqlDataReader dataReader = command1.ExecuteReader();
            while (dataReader.Read())
            {
                lblId.Text = dataReader[0].ToString();
            }
            connection.Close();

            //Borclar tablosuna ögrenci aktarma
            SqlCommand command2 = new SqlCommand("Insert into Tbl_Borclar (OgrId,OgrAd,OgrSoyad) values (@k1,@k2,@k3)", connection);
            command2.Parameters.AddWithValue("@k1", lblId.Text);
            command2.Parameters.AddWithValue("@k2", txtOgrAd.Text);
            command2.Parameters.AddWithValue("@k3", txtOgrSoyad.Text);
            _komut(command2);
            

            // oda kontenjanı azaltma
            SqlCommand command3 = new SqlCommand("Update Tbl_Oda set OdaAktif=OdaAktif+1 where OdaNo=@oda1", connection);
            command3.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            _komut(command3);
            _temizle();

        }
    }
}
