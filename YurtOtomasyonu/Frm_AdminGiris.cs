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
    public partial class Frm_AdminGiris : Form
    {
        public Frm_AdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Tbl_Yonetici where YoneticiAd=@p1 and YoneticiSifre=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtKullaniciad.Text);
            command.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Frm_AnaForm anaForm = new Frm_AnaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciad.Text = "";
                txtSifre.Text = "";
                txtKullaniciad.Focus();
            }
            connection.Close();
        }
    }
}
