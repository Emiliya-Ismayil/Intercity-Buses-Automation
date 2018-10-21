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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool[] yetki = new bool[7];
            string sorgu = "select KullaniciID,KullaniciAdi,Sifre,Adi,Soyadi from Kullanici where KullaniciAdi='" + txtKullaniciAdi.Text + "' and Sifre ='" + txtSifre.Text + "'";
            try                      
            {
                SqlConnection cnn = Asistan.baglan();

               SqlCommand komut = new SqlCommand(sorgu, cnn);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    Form1.mdi.yönetimselİşlemlerToolStripMenuItem.Enabled = true;
                     Form1.mdi.BiletToolStripMenuItem.Enabled = true;
                    Form1.mdi.lblKullanici.Text = "Kullanıcı : " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString(); this.Close();
                    Form1.mdi.kullanıcıİşlemleriToolStripMenuItem.Enabled = true;
                    Form1.mdi.biletSatisToolStripMenuItem.Enabled = true;
                    Form1.mdi.biletSilToolStripMenuItem.Enabled =true;
                    Form1.mdi.seferlerToolStripMenuItem.Enabled = true;
                    Form1.mdi.otobüslerToolStripMenuItem.Enabled = true;
                    Form1.mdi.şoförlerToolStripMenuItem.Enabled = true;
                    Form1.mdi.oturumuKapatToolStripMenuItem.Enabled = true;
                    Form1.mdi.kullanıcılarıListeleToolStripMenuItem.Enabled = true;
                    Form1.mdi.ekleSilDüzenleToolStripMenuItem.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş ...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

      
    }
}
