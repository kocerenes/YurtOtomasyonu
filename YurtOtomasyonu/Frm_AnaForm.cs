using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YurtOtomasyonu
{
    public partial class Frm_AnaForm : Form
    {
        public Frm_AnaForm()
        {
            InitializeComponent();
        }

        baglantiAdres cnnct = new baglantiAdres();

        private void Frm_AnaForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select OgrId,OgrAd,OgrSoyad,OgrOdaNo from tbl_Ogrenci",cnnct.connection());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis==DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis==DialogResult.No)
            {

            }

        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OgrKayit ogrkayit = new Frm_OgrKayit();
            ogrkayit.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OgrListesi ogrListe = new Frm_OgrListesi();
            ogrListe.Show();
        }

        private void öğreciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OgrListesi ogrListesi = new Frm_OgrListesi();
            ogrListesi.Show();
        }

        private void böşümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bolumler bolumler = new Frm_Bolumler();
            bolumler.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bolumler bolumler = new Frm_Bolumler();
            bolumler.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Odemeler odemeler = new Frm_Odemeler();
            odemeler.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gider gider = new Frm_Gider();
            gider.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GiderListesi giderListesi = new Frm_GiderListesi();
            giderListesi.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Geliristatistik gelirIstatistik = new Frm_Geliristatistik();
            gelirIstatistik.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sifreislemleri sifreIslemleri = new Frm_Sifreislemleri();
            sifreIslemleri.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Personel personel = new Frm_Personel();
            personel.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NotEkle notEkle = new Frm_NotEkle();
            notEkle.Show();
        }

        private void raporAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OgrenciRapor ogrRapor = new Frm_OgrenciRapor();
            ogrRapor.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tek gayemiz öğrencilere huzurlu ve güvenli bir barınma ortamı sağlamak.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
