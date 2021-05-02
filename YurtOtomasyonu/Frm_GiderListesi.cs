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
    public partial class Frm_GiderListesi : Form
    {
        public Frm_GiderListesi()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void _giderList()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Giderler", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Frm_GiderListesi_Load(object sender, EventArgs e)
        {
            _giderList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_GiderGuncelle giderGuncelle = new Frm_GiderGuncelle();
            giderGuncelle.id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            giderGuncelle.elektrik = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            giderGuncelle.su = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            giderGuncelle.dogalgaz = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            giderGuncelle.internet = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            giderGuncelle.gida = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            giderGuncelle.personel = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            giderGuncelle.diger = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            giderGuncelle.Show();
               
        }
    }
}
