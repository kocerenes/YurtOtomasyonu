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
using System.Runtime.InteropServices;

namespace YurtOtomasyonu
{
    public partial class Frm_Geliristatistik : Form
    {
        public Frm_Geliristatistik()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6;Initial Catalog=YurtOtomasyon;Integrated Security=True");

        private void Frm_Geliristatistik_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Sum(OdemeMiktar) from Tbl_Kasa", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblKasa.Text = dataReader[0].ToString()+ " TL";
            }
            connection.Close();

            //cmbAylara her ayı 1 kere ekleme işlem
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select Distinct(OdemeAy) from Tbl_Kasa", connection);
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                cmbAylar.Items.Add(dataReader1[0].ToString());
            }
            connection.Close();


            //geliristatistik grafiğine veri tabanından veri çekme
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select OdemeAy,sum(OdemeMiktar) from Tbl_Kasa Group by OdemeAy", connection);
            SqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(dataReader2[0], dataReader2[1]);
            }
            connection.Close();
        }


        private void cmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Sum(OdemeMiktar) from Tbl_Kasa where OdemeAy=@p1", connection);
            command.Parameters.AddWithValue("@p1", cmbAylar.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblSecilenAy.Text = dataReader[0].ToString();
            }
            connection.Close();

        }
    }
}
