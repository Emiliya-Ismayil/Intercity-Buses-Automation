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

namespace Tur
{
    public partial class BiletSil : Form
    {
        public BiletSil()
        {
            InitializeComponent();
        }

        private void btnBiletAra_Click(object sender, EventArgs e)
        {
            DataTable dtBilet = new DataTable();
            dtBilet = Asistan.dataTable("select * from Bilet where BiletID=" + txtBiletNo.Text);
            DataTable dtYolcu = new DataTable();
            dtYolcu = Asistan.dataTable("select * from Yolcu Inner Join Bilet on Yolcu.YolcuID=Bilet.YolcuID and Yolcu.SeferID=Bilet.SeferID where Bilet.BiletID=" + txtBiletNo.Text);
            DataTable dtSefer = new DataTable();
            dtSefer = Asistan.dataTable("select Tarih from Seferler where SeferID=" + dtBilet.Rows[0]["SeferID"].ToString());

            if (dtYolcu.Rows.Count > 0 && dtBilet.Rows.Count > 0)
            {
                lblBiletNo.Text = dtBilet.Rows[0][0].ToString();
                lblAd.Text = dtYolcu.Rows[0]["Adi"].ToString();
                lblSoyad.Text = dtYolcu.Rows[0]["Soyadi"].ToString();
                lblBİletFiyati.Text = dtBilet.Rows[0]["Fiyat"].ToString();
                lblKoltukNo.Text = dtBilet.Rows[0]["KoltukNo"].ToString();
                lbCinsiyet.Text = dtYolcu.Rows[0]["Cinsiyet"].ToString();
                lbTelefon.Text = dtYolcu.Rows[0]["Telefon"].ToString();
                lbIDYolcu.Text = dtYolcu.Rows[0]["YolcuID"].ToString();
           
              lblSeferTarih.Text = dtSefer.Rows[0]["Tarih"].ToString();
                lblSeferNo.Text = dtBilet.Rows[0]["SeferID"].ToString();
                if (dtBilet.Rows[0]["OdemeSekli"].ToString() == "True")
                {
                    lblSatisTipi.Text = "Nakit";
                }
                else
                {
                    lblSatisTipi.Text = "Kredi Kartı";
                }
            }
            else
            {
                MessageBox.Show("Biletbulunamadı...");
            }

        }

        private void btnBiletSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Silmek istiyor musunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            {
                string srg1 = "delete from Yolcu  where YolcuID= "+lbIDYolcu.Text;
                string srg = "DELETE FROM Bilet WHERE KoltukNo= " + lblBiletNo.Text;


                 Asistan.iduSql(srg1);
                   Asistan.iduSql(srg);
       
                lbIDYolcu.Text = "*";
                lblAd.Text = "*";
                lblSoyad.Text = "*"; lbCinsiyet.Text = "*"; lbTelefon.Text = "*"; lblSeferTarih.Text = "*"; lblSeferNo.Text = "*";  lblSatisTipi.Text = "*"; lblKoltukNo.Text = "*"; lblBiletNo.Text = "*"; lblBİletFiyati.Text = "*";
            }

        }

        private void BiletSil_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }
    }
}
