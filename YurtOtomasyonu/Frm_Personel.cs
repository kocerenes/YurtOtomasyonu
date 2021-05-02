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
    public partial class Frm_Personel : Form
    {
        public Frm_Personel()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void _liste()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Personel", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void _temizle()
        {
            txtPersonelGorev.Text = "";
            txtPersonalAd.Text = "";
            txtPersonelId.Text = "";
        }

        private void _komut(SqlCommand kmt)
        {
            kmt.Connection.Open();
            kmt.ExecuteNonQuery();
            kmt.Connection.Close();
        }


        private void Frm_Personel_Load(object sender, EventArgs e)
        {
            _liste();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult ekle = new DialogResult();
            ekle = MessageBox.Show("Yeni personel eklemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ekle==DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p1", txtPersonalAd.Text);
                command.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                _komut(command);
                _temizle();
                _liste();
            }
            if (ekle==DialogResult.No)
            {
                _temizle();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Seçilen personeli silmek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sil==DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Delete Tbl_Personel where PersonelId=@p1", connection);
                command.Parameters.AddWithValue("@p1", txtPersonelId.Text);
                _komut(command);
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
            guncelle = MessageBox.Show("Personelin bilgilerini güncellemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (guncelle==DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Update Tbl_Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelId=@p3", connection);
                command.Parameters.AddWithValue("@p1", txtPersonalAd.Text);
                command.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                command.Parameters.AddWithValue("@p3", txtPersonelId.Text);
                _komut(command);
                _temizle();
                _liste();
            }
            if (guncelle==DialogResult.No)
            {
                _temizle();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPersonalAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPersonelGorev.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
