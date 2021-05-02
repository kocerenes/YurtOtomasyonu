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
    public partial class Frm_Sifreislemleri : Form
    {
        public Frm_Sifreislemleri()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void _liste()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Yonetici", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Frm_Sifreislemleri_Load(object sender, EventArgs e)
        {
            _liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYoneticiID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKullaniciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void _temizle()
        {
            txtKullaniciAd.Text = "";
            txtSifre.Text = "";
            txtYoneticiID.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult ekle = new DialogResult();
            ekle = MessageBox.Show("Yeni yönetici eklemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ekle==DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_Yonetici (YoneticiAd,YoneticiSifre) values (@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                command.Parameters.AddWithValue("@p2", txtSifre.Text);
                command.ExecuteNonQuery();
                connection.Close();
                _temizle();
                _liste();
            }
            if (ekle == DialogResult.No)
            {
                _temizle();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil= MessageBox.Show("Yöneticiyi silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil==DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Tbl_Yonetici where YoneticiId=@p1", connection);
                command.Parameters.AddWithValue("@p1", txtYoneticiID.Text);
                command.ExecuteNonQuery();
                connection.Close();
                _temizle();
                _liste();
            }
            if (sil==DialogResult.No)
            {
                _temizle();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult guncelle = new DialogResult();
            guncelle= MessageBox.Show("Yönetici bilgilerini güncellemek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (guncelle==DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Update Tbl_Yonetici set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiId=@p3", connection);
                command.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                command.Parameters.AddWithValue("@p2", txtSifre.Text);
                command.Parameters.AddWithValue("@p3", txtYoneticiID.Text);
                command.ExecuteNonQuery();
                connection.Close();
                _temizle();
                _liste();
            }
            if (guncelle==DialogResult.No)
            {
                _temizle();
            }

        }
    }
}
