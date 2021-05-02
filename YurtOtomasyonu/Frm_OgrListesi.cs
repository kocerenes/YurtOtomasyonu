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
    public partial class Frm_OgrListesi : Form
    {
        public Frm_OgrListesi()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        public void OgrListele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Ogrenci", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Frm_OgrListesi_Load(object sender, EventArgs e)
        {
            OgrListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_OgrDuzenle ogr = new Frm_OgrDuzenle();
            ogr.ıd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ogr.ad = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ogr.soyad = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ogr.tc = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ogr.telefon = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            ogr.dogum = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            ogr.bolum = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            ogr.mail = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            ogr.odaNo = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            ogr.veliAdSoyad = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            ogr.veliNo = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            ogr.Adres = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            ogr.Show();
        }
    }
}
