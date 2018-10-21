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
    public partial class KullaniciIslem : Form
    {
        public KullaniciIslem()
        {
            InitializeComponent();
        }
        string dgvYenile = "SELECT KullaniciID,Adi,Soyadi,KullaniciAdi ,Sifre FROM Kullanici";
        private void KullaniciIslem_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Form1 frm = new Form1();
            if (frm.ekleSilDüzenleToolStripMenuItem.Enabled == false)
            {
                panel1.Visible = false;
            }
            string srg = "SELECT KullaniciID,Adi,Soyadi,KullaniciAdi ,Sifre FROM Kullanici";

            SqlConnection con = Asistan.baglan();
            SqlCommand cmd = new SqlCommand(srg, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewListe.DataSource = dt;


        }
        public bool silme = false;
        private void btnSil_Click(object sender, EventArgs e)
        {
            silme = true;
            string srgSil = "delete from Kullanici where KullaniciID=" + dataGridViewListe.CurrentRow.Cells[0].Value.ToString();
      
            SqlConnection con = Asistan.baglan();
            SqlCommand cmd = new SqlCommand(srgSil, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close(); DialogResult sonuc = MessageBox.Show("Silme onaylansın mı ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
            
                Asistan.dgvYenile(dgvYenile, dataGridViewListe);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string srgEkle = "INSERT INTO Kullanici(KullaniciAdi ,Sifre,Adi,Soyadi) VALUES ('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "')";
            try
            {
                Asistan.iduSql(srgEkle);
             
                MessageBox.Show("İşlem tamamlandı...");
                Asistan.dgvYenile(dgvYenile, dataGridViewListe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata");

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {


       

            string srgKullaniciDuzenle = "UPDATE Kullanici SET KullaniciAdi ='" + txtKullaniciAdi.Text + "' ,[Sifre] ='" + txtSifre.Text + "'    ,[Adi] ='" + txtAd.Text + "',[Soyadi] ='" + txtSoyad.Text + "' WHERE KullaniciID=" + dataGridViewListe.CurrentRow.Cells[0].Value.ToString();
            Asistan.iduSql(srgKullaniciDuzenle);
            Asistan.iduSql("ENABLE TRIGGER guncelle ON Kullanici");
           
            Asistan.dgvYenile(dgvYenile, dataGridViewListe);
        }

        private void dataGridViewListe_SelectionChanged(object sender, EventArgs e)
        {

            if (silme) goto bitis;

            
            string srgSifre = "SELECT Sifre FROM Kullanici";
       
            txtAd.Text = dataGridViewListe.CurrentRow.Cells[1].Value.ToString();
            txtKullaniciAdi.Text = dataGridViewListe.CurrentRow.Cells[3].Value.ToString();

            txtSoyad.Text = dataGridViewListe.CurrentRow.Cells[2].Value.ToString();
            DataTable dtSifre = Asistan.dataTable(srgSifre);
            txtSifre.Text = dtSifre.Rows[0][0].ToString();

       
            bitis:;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAd.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            for (int i = 0; i < 7; i++)
            {
              

            }
        }



    }
}

