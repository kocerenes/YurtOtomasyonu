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
    public partial class Frm_Gider : Form
    {
        public Frm_Gider()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Tbl_Giderler (Elektrik,Su,Dogalgaz,Internet,Gida,Personel,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
            command.Parameters.AddWithValue("@p1", txtElektrik.Text);
            command.Parameters.AddWithValue("@p2", txtSu.Text);
            command.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
            command.Parameters.AddWithValue("@p4", txtInternet.Text);
            command.Parameters.AddWithValue("@p5", txtGida.Text);
            command.Parameters.AddWithValue("@p6", txtPersonel.Text);
            command.Parameters.AddWithValue("@p7", txtDiger.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Gider fiyatları belirlendi.");

        }
    }
}
