using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YurtOtomasyonu
{
    public partial class Frm_NotEkle : Form
    {
        public Frm_NotEkle()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt yeri seçin";
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";
            saveFileDialog1.InitialDirectory = "C:\\Users\\enes\\source\\repos\\YurtOtomasyonu\\YurtOtomasyonu\\Notlar";
            saveFileDialog1.ShowDialog();
            StreamWriter notKayit = new StreamWriter(saveFileDialog1.FileName);
            notKayit.WriteLine(richTextBox1.Text);
            notKayit.Close();
            MessageBox.Show("Notunuz başarıyla kaydedildi.");
            richTextBox1.Text = "";
        }
    }
}
