using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur
{
    public partial class Sofor : Form
    {
        public Sofor()
        {
            InitializeComponent(); this.Dock = DockStyle.Fill;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string sorgu = "INSERT INTO Soforler ([Adi],[Soyadi],[TcNo],[Telefon],[Adres]) VALUES ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTC.Text + "','" + txtTel.Text + "','" + txtAdres.Text + "')";
            string sorgu_liste = "SELECT [SoforID],[Adi],[Soyadi],[TcNo],[Telefon],[Adres] FROM Soforler";
            Asistan.iduSql(sorgu);
            MessageBox.Show("İşlem tamamlandı...");
            Asistan.dgvYenile(sorgu_liste, dgvSofor);
        }

        private void Sofor_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            string sorgu_liste = "SELECT [SoforID],[Adi],[Soyadi],[TcNo],[Telefon],[Adres] FROM Soforler";
            Asistan.dgvYenile(sorgu_liste, dgvSofor);
        }


    }
}
