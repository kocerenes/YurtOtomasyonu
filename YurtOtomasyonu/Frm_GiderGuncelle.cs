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
    public partial class Frm_GiderGuncelle : Form
    {
        public Frm_GiderGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        public string elektrik, su, dogalgaz, internet, gida, personel, diger,id;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult soruGuncelle = new DialogResult();
            soruGuncelle = MessageBox.Show("Gider listesinin güncellemesi gerçekleştirilsin mi?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soruGuncelle==DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Update Tbl_Giderler set Elektrik=@p2,Su=@p3,Dogalgaz=@p4,Internet=@p5,Gida=@p6,Personel=@p7,Diger=@p8 where GiderId=@p1", connection);
                command.Parameters.AddWithValue("@p1", txtId.Text);
                command.Parameters.AddWithValue("@p2", txtElektrik.Text);
                command.Parameters.AddWithValue("@p3", txtSu.Text);
                command.Parameters.AddWithValue("@p4", txtDogalgaz.Text);
                command.Parameters.AddWithValue("@p5", txtInternet.Text);
                command.Parameters.AddWithValue("@p6", txtGida.Text);
                command.Parameters.AddWithValue("@p7", txtPersonel.Text);
                command.Parameters.AddWithValue("@p8", txtDiger.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            if (soruGuncelle==DialogResult.No)
            {

            }
        }

        private void Frm_GiderGuncelle_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su.ToString();
            txtDogalgaz.Text = dogalgaz;
            txtInternet.Text = internet;
            txtGida.Text = gida;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }
    }
}
