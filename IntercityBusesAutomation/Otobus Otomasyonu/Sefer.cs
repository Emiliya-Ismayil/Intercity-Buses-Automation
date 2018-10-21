using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur
{
    public partial class Sefer : Form
    {
        public Sefer()
        {
            InitializeComponent();
        }

        private void Sefer_Load(object sender, EventArgs e)
        {
          
            this.Dock = DockStyle.Fill;
            string sorgu_il = "SELECT  ilKodu,ilAdi FROM iller";
            string sorgu_arac = "SELECT Plaka FROM Araclar";
            string sorgu_sofor = "SELECT  SoforID,Adi +' '+ Soyadi as Ad_Soyad FROM Soforler";
            Asistan.comboBoxDoldur(comboBoxKalkis, sorgu_il, "ilAdi", "ilKodu");
            Asistan.comboBoxDoldur(comboBoxVaris, sorgu_il, "ilAdi", "ilKodu");
            Asistan.comboBoxDoldur(comboBoxArac, sorgu_arac, "Plaka", "Plaka");
            Asistan.comboBoxDoldur(comboBoxSofor, sorgu_sofor, "Ad_Soyad", "SoforID");
     
            string sorgu_sefer = "SELECT SeferID,Plaka,Kalkis as Kalkış,Varis as Varış,Tarih as TarihSaat  FROM seferListe";

            
         Asistan.gridDoldur(sorgu_sefer,dgvSefer);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
            else
            {
           
                string tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd ");
                string saat = textBox1.Text + ":" + textBox2.Text + ":00.000";
                string sorgu_Kayit = "INSERT INTO Seferler (Kalkis ,Varis,Tarih,Arac ,Sofor) VALUES(" + comboBoxKalkis.SelectedValue + "," + comboBoxVaris.SelectedValue + ",'" + tarih + saat + "','" + comboBoxArac.SelectedValue + "'," + comboBoxSofor.SelectedValue + ")";

            
                Asistan.iduSql(sorgu_Kayit);
                MessageBox.Show("İşlem Tamamlandı...");
          
            }



        }

     
        private void button1_Click_1(object sender, EventArgs e)
        {

            string sorgu_sefer = "SELECT SeferID,Kalkis as Kalkış,Varis as Varış,Tarih as TarihSaat  FROM Seferler";
            Asistan.gridDoldur(sorgu_sefer, dgvSefer);
        }
    }
}
