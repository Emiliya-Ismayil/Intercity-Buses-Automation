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
    public partial class Otobus : Form
    {
        public Otobus()
        {
            InitializeComponent();
        }

        private void Otobus_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            string sorgu = "SELECT Plaka,KoltukSayisi  FROM Araclar";
            Asistan.gridDoldur(sorgu, dgvOtobus);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Araclar (Plaka ,KoltukSayisi) VALUES ('" + txtPlaka.Text + "'," + txtKoltukSay.Text + ")";
            Asistan.iduSql(sorgu);
            MessageBox.Show("İşlem tamamlandı...");
            Asistan.dgvYenile("SELECT Plaka,KoltukSayisi FROM Araclar", dgvOtobus);
        }


    }
}
