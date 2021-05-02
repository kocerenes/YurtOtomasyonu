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
    public partial class Frm_Bolumler : Form
    {
        public Frm_Bolumler()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void _bolumListele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Bolum", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void _komut(SqlCommand kmt)
        {
            kmt.Connection.Open();
            kmt.ExecuteNonQuery();
            kmt.Connection.Close();
        }

        private void Frm_Bolumler_Load(object sender, EventArgs e)
        {
            _bolumListele();
        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Bolum (BolumAd) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            _komut(command);
            MessageBox.Show("Bölüm başarıyla eklendi.");
            _bolumListele();
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Bölümü silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil==DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Delete from Tbl_Bolum where BolumId=@p1", connection);
                command.Parameters.AddWithValue("@p1", txtId.Text);
                _komut(command);
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti.");
                txtAd.Text = "";
                txtId.Text = "";
                _bolumListele();
            }
            if (sil==DialogResult.No)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pcbGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_BOlum set BolumAd=@p1 where BolumId=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtId.Text);
            _komut(command);
            MessageBox.Show("Değişiklikler başarıyla kaydedildi.");
            _bolumListele();
        }
    }
}
