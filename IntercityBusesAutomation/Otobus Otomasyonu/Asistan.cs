using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur
{
    class Asistan
    {
        public static SqlConnection baglan()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-F1CKCC5;Initial Catalog=Otobus Otomasyonu;Integrated Security=True";           
            return cnn;
        }

        public static void dgvYenile(string sorgu, DataGridView dgv)
        {
            SqlConnection baglanti = Asistan.baglan();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            dgv.DataSource = dt;
            baglanti.Close();
        }
        public static DataTable dataTable(string sorgu)
        {
            SqlConnection baglanti = Asistan.baglan();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); return dt;
        }

        public static void iduSql(string srg)
        {
            SqlConnection cn = Asistan.baglan();
            SqlCommand cmd = new SqlCommand(srg, cn);
           
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static string tarihFormat(string gun, string ay, string yil)
        {
            if (int.Parse(gun) < 10)
            {
                gun = "0" + gun;
            }
            if (int.Parse(ay) < 10)
            {
                ay = "0" + ay;
            }
            string tarih = yil + "-" + ay + "-" + gun;
            return tarih;
        }
        public static void gridDoldur( string sorgu,DataGridView dgv)
        {
            SqlConnection baglanti = Asistan.baglan();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "seferListe";
            da.Fill(dt);
            dgv.DataSource = dt;
            baglanti.Close();
        }
  
        public static void KulListele(string sorgu, DataGridView dgv)
        {
            SqlConnection baglanti = Asistan.baglan();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
          
            da.Fill(dt);
            dgv.DataSource = dt;
            baglanti.Close();
        }

        public static void comboBoxDoldur(ComboBox cmb, string sorgu, string displayMember, string ValueMember)
        {
            SqlConnection baglanti = Asistan.baglan();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb.DataSource = dt; cmb.DisplayMember = displayMember;
            cmb.ValueMember = ValueMember;
            baglanti.Close();

        }

        public static void comboBoxTarih(ComboBox cmbYil, ComboBox cmbAy, ComboBox cmbGun)
        {
            cmbYil.Items.Clear();
            cmbYil.Items.Clear();
            for (int i = 2000; i <= DateTime.Now.Year; i++) cmbYil.Items.Add(i);


            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            for (int x = 1; x <= 12; x++)
            {
                cmbAy.Items.Add(aylar[x - 1]);
            }
            for (int y = 1; y <= 31; y++) cmbGun.Items.Add(y);
            cmbYil.SelectedIndex = -1;
            cmbAy.SelectedIndex = -1;
            cmbGun.SelectedIndex = -1;
        }

        internal static void dgvYenile(string dgvYenile, object dataGridViewListe)
        {
            throw new NotImplementedException();
        }

        public static void gunHesapla(ComboBox cmbYil, ComboBox cmbAy, ComboBox cmbGun)
        {

            int gun = DateTime.DaysInMonth((int)cmbYil.SelectedItem, (int)cmbAy.SelectedIndex + 1);
            cmbGun.Items.Clear();
            for (int say = 1; say <= gun; say++) cmbGun.Items.Add(say); cmbGun.SelectedIndex = 0;
        }
    }
}
