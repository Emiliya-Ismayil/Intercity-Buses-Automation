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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            string srg = "SELECT KullaniciID,KullaniciAdi ,Sifre,Adi,Soyadi FROM Kullanici";

            Asistan.KulListele(srg, dataGridViewKullanicilar);

        }

        //private void btnYetki_Click(object sender, EventArgs e)
        //{
         
        //    string srg = "select Erisebilir from Izin where KullaniciNo=" + dataGridViewKullanicilar.CurrentRow.Cells[0].Value.ToString() + "order by (YetkiNo)";
        //    DataTable dt = Asistan.dataTable(srg);
        //    for (int i = 0; i < 7; i++)
        //    {
        //        bool deger = Convert.ToBoolean(dt.Rows[i][0].ToString());
        


        //    }
        //}

       
    }
}
