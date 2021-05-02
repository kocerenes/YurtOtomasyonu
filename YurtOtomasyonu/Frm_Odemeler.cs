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
    public partial class Frm_Odemeler : Form
    {
        public Frm_Odemeler()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void _liste()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Borclar", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void _komut(SqlCommand komut)
        {
            komut.Connection.Open();
            komut.ExecuteNonQuery();
            komut.Connection.Close();
        }

        private void _temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtOdenen.Text = "";
            txtKalan.Text = "";
        }

        private void Frm_Odemeler_Load(object sender, EventArgs e)
        {
            _liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKalan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //odenen tutarı kalan borcdan cıkarma
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt32(txtOdenen.Text);
            kalan = Convert.ToInt32(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();

            //odenen tutarı veri tabanında güncelleme
            DialogResult Odeme = new DialogResult();
            Odeme = MessageBox.Show("Ödeme işlemi gerçekleştirilsin mi?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Odeme==DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Update Tbl_Borclar set OgrKalanBorc=@p1 where OgrId=@p2", connection);
                command.Parameters.AddWithValue("@p1", txtKalan.Text);
                command.Parameters.AddWithValue("@p2", txtId.Text);
                _komut(command);

                SqlCommand command1 = new SqlCommand("Insert into Tbl_Kasa (OgrId,OdemeAy,OdemeMiktar) values (@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", txtId.Text);
                command1.Parameters.AddWithValue("@p2", cmbOdenenAy.Text);
                command1.Parameters.AddWithValue("@p3", txtOdenen.Text);
                _komut(command1);

                _liste();
            }
            if (Odeme==DialogResult.No)
            {
                MessageBox.Show("Ödeme işlemi gerçekleşmedi.");
            }
            _temizle();
            
            
        }
    }
}
