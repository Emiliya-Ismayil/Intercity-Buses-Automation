using System;
using System.Collections;
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
    public partial class BiletSatis : Form
    {
        ArrayList koltuklar = new ArrayList();
        Button BasılanButon;
        string[] yolcular = new string[100];
        Point nokta;
        string[] koltukcins = new string[100];

        int yolcuSayisi = 0, koltukSayisi = 0;

        public BiletSatis()
        {
            InitializeComponent();
        }

        private void BiletSatis_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            string sorgu_ilKalkis = "select distinct i.ilKodu,i.ilAdi from Seferler s, iller i where i.ilKodu=s.Kalkis";
            Asistan.comboBoxDoldur(comboBoxKalkis, sorgu_ilKalkis, "ilAdi", "ilKodu"); comboBoxKalkis.SelectedIndex = -1; comboBoxKalkis.Text = "Lütfen Seçiniz";


            comboBoxOSekli.Text = "Lütfen Seçiniz";

        }


        private void comboBoxKalkis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxVaris.Enabled = true;
            string sorgu_ilVaris = "select distinct i.ilKodu,i.ilAdi from Seferler s, iller i where i.ilKodu=s.Varis and s.Kalkis=" + comboBoxKalkis.SelectedValue.ToString();
            Asistan.comboBoxDoldur(comboBoxVaris, sorgu_ilVaris, "ilAdi", "ilKodu"); comboBoxVaris.SelectedIndex = -1; comboBoxVaris.Text = "Lütfen Seçiniz";
            if (comboBoxVaris.SelectedIndex != -1)
            {
                if (comboBoxVaris.SelectedValue.ToString() == comboBoxKalkis.SelectedValue.ToString())
                {
                    MessageBox.Show("Aynı iller seçilemez");
                }
                else
                {
                    string sorgu_sefer = "SELECT SeferID,Tarih FROM Seferler where Kalkis=" + comboBoxKalkis.SelectedValue + " and Varis=" + comboBoxVaris.SelectedValue;
                    Asistan.iduSql(sorgu_sefer); Asistan.comboBoxDoldur(comboBoxSefer, sorgu_sefer, "SeferID", "SeferID");
                    comboBoxSefer.Enabled = true; comboBoxSefer.Text = "Lütfen Seçiniz";
                }


            }


        }

        private void comboBoxVaris_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxVaris.SelectedIndex != -1)
            {
                if (comboBoxVaris.SelectedValue.ToString() == comboBoxKalkis.SelectedValue.ToString())
                {
                    MessageBox.Show("Aynı iller seçilemez");
                }
                else
                {
                    string sorgu_sefer = "select s.SeferID,s.Tarih,a.KoltukSayisi from Seferler s, Araclar a where s.Arac=a.Plaka and s.Kalkis=" + comboBoxKalkis.SelectedValue + " and s.Varis=" + comboBoxVaris.SelectedValue;
                    Asistan.comboBoxDoldur(comboBoxSefer, sorgu_sefer, "SeferID", "KoltukSayisi"); comboBoxSefer.Enabled = true;
                    comboBoxSefer.Text = "Lütfen Seçiniz";
                }


            }

        }


        private void koltuklarClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            BasılanButon = (Button)sender;
            int koltukNo = int.Parse(BasılanButon.Text);
            string cinsiyet = "";
            DialogResult secim = MessageBox.Show("Bu koltuğa kayıt yapılsın mı ?", "Koltuk Onay", MessageBoxButtons.YesNo);

            if (secim == DialogResult.Yes)
            {
                if (txtUcret.Text == "" || comboBoxOSekli.SelectedIndex == -1)
                {
                    MessageBox.Show("Ödeme bilgilerini giriniz."); goto hata;
                }
                if (rdoBayan.Checked == true)
                {
                    cinsiyet = "K";
                    koltukcins[koltukNo] = "K";
                    BasılanButon.BackColor = Color.LightPink;
                }
                else if (rdoErkek.Checked == true)
                {
                    cinsiyet = "E";
                    koltukcins[koltukNo] = "E";
                    BasılanButon.BackColor = Color.LightBlue;
                }
                else
                {

                    MessageBox.Show("Hata ! Lütfen seçimlerinizi kontrol ediniz..."); goto hata;
                }
                BasılanButon.Enabled = false;
                yolcular[koltukNo - 1] = txtAd.Text.PadRight(12, ' ') + txtSoyad.Text.PadRight(12, ' ') + cinsiyet.PadRight(8, ' ');
                yolcuSayisi++;
                string odeme = "";
                if (comboBoxOSekli.Text == "Nakit")
                {
                    odeme = "1";
                }
                else
                {
                    odeme = "2";
                }
                string tarih = Asistan.tarihFormat(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());

                string Yolcu_kayit = " Insert into Yolcu(SeferID,Adi,Soyadi,Cinsiyet,Telefon,Aciklama) VALUES (" + comboBoxSefer.Text + ",'" + txtAd.Text + "','" + txtSoyad.Text + "','" + cinsiyet + "','" + txtTel.Text + "',' ')"; Asistan.iduSql(Yolcu_kayit);
                DataTable dtSefer = Asistan.dataTable("Select * from Seferler where SeferID=" + comboBoxSefer.GetItemText(comboBoxSefer.SelectedItem));
                DataTable dtYolcu = Asistan.dataTable("Select * from Yolcu where SeferID=" + comboBoxSefer.Text + " and Adi='" + txtAd.Text + "' and  Soyadi='" + txtSoyad.Text + "'");
                string koltuk_kayit = "Insert into Koltuk(Plaka,KoltukNo,SeferID,YolcuID,Fiyat,OdemeSekli,AlınmaTarihi) VALUES ('" + dtSefer.Rows[0]["Arac"].ToString() + "','" + BasılanButon.Text + "'," + comboBoxSefer.Text + "," + dtYolcu.Rows[0]["YolcuID"] + "," + txtUcret.Text + "," + odeme + ",'" + tarih + "')";

                Asistan.iduSql(koltuk_kayit);          
                SqlConnection cnn = Asistan.baglan();        
                cnn.Open();
        
               SqlCommand cmd = new SqlCommand("Insert into Bilet(Plaka,SeferID,KoltukNo,Fiyat,OdemeSekli,YolcuID) values(@Plaka,@SeferID,@KoltukNo,@Fiyat,@OdemeSekli,@YolcuID)",cnn);


                cmd.Parameters.AddWithValue("@Plaka", dtSefer.Rows[0]["Arac"].ToString());
                cmd.Parameters.AddWithValue("@KoltukID", "Koltuk.KoltukID");
                cmd.Parameters.AddWithValue("@SeferID", comboBoxSefer.Text);
                cmd.Parameters.AddWithValue("@KoltukNo", BasılanButon.Text);
                cmd.Parameters.AddWithValue("@Fiyat", txtUcret.Text);
                cmd.Parameters.AddWithValue("@OdemeSekli", odeme);
                cmd.Parameters.AddWithValue("@YolcuID", dtYolcu.Rows[0]["YolcuID"]);

         
                cmd.ExecuteNonQuery(); cnn.Close();


                formTemizle();
                hata:;

            }



        }



        private void comboBoxSefer_SelectionChangeCommitted(object sender, EventArgs e)
        {


            int koltukSay = Convert.ToInt32(comboBoxSefer.SelectedValue.ToString());



            string doluKoltuk = "select s.SeferID,y.Cinsiyet,k.YolcuID,k.KoltukNo from Yolcu y,Seferler s ,Koltuk k where s.SeferID=k.SeferID and y.YolcuID=k.YolcuID and s.SeferID=" + comboBoxSefer.GetItemText(comboBoxSefer.SelectedItem);
            DataTable dt = Asistan.dataTable(doluKoltuk);

            for (int i = 0; i < koltukSay; i++)
            {

                yolcular[i] = "BOŞ";
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                yolcular[int.Parse(dt.Rows[i][3].ToString()) - 1] = dt.Rows[i][1].ToString();
            }
            otobusCiz(koltukSay);

            DataTable dtSeferZaman = Asistan.dataTable("select s.SeferID,s.Tarih from Seferler s, Araclar a where s.Arac=a.Plaka and s.Kalkis=" + comboBoxKalkis.SelectedValue + " and s.Varis=" + comboBoxVaris.SelectedValue + " and s.SeferID=" + comboBoxSefer.GetItemText(comboBoxSefer.SelectedItem));
            string[] tarihSaat = dtSeferZaman.Rows[0][1].ToString().Split(' ');
            lblSeferSaat.Text = tarihSaat[1].Substring(0, 5);
            lblSeferTarih.Text = tarihSaat[0];







        }
        void otobusCiz(int koltukSayisi)
        {



            grpbKoltuklar.Controls.Clear();

            int sutun = 0, bosluk = 0, satir = 0; ;
            bool onkapi = false;


            kapiciz(150, 37, "onkapi1", "Kapı");
            kapiciz(30, 37, "sofor", "Şoför");



            if (koltukSayisi >= 27)
            {
                koltukSayisi += 2;
            }

            for (int i = 0; i < koltukSayisi; i++)
            {
                if (i == 26)
                {
                    Button kapi = new Button();
                    kapi.Name = "onkapi";
                    kapi.TabIndex = i;
                    kapi.TabStop = false;
                    kapi.Text = "Kapı";
                    kapi.Size = new System.Drawing.Size(70, 25);
                    nokta = new System.Drawing.Point(30 + sutun * 30 + 40 + sutun * 10 + bosluk, 30 + satir * kapi.Height * 3 / 2);
                    kapi.Location = nokta;
                    kapi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    kapi.BackColor = Color.Gray;
                    kapi.BringToFront();
                    grpbKoltuklar.Controls.Add(kapi); sutun = 0; onkapi = true;
                }

                else
                {


                    if (i % 4 == 0)
                    {
                        satir++;
                        sutun = 0;
                        bosluk = 0; ;
                    }
                    else
                        if (i % 2 == 0 && i != 0)
                        bosluk = 40;

                    Button koltuk = new Button();
                    koltuk.Name = i.ToString();
                    koltuk.TabIndex = i;
                    koltuk.TabStop = false;
                    if (onkapi == true)
                    {

                        koltuk.Text = (i - 1).ToString();


                    }
                    else
                    {
                        koltuk.Text = (i + 1).ToString();
                    }
                    koltuk.Size = new System.Drawing.Size(30, 25);
                    nokta = new System.Drawing.Point(30 + sutun * koltuk.Width + sutun * 10 + bosluk, 30 + satir * koltuk.Height * 3 / 2);
                    koltuk.Location = nokta;
                    koltuk.BringToFront();
                    koltuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    koltuk.BackColor = Color.Gray;
                    koltuk.MouseDown += new MouseEventHandler(this.koltuklarClick);
                    if (onkapi == true)
                    {
                        i = i - 2;

                    }
                    if (yolcular[i] != "BOŞ")
                    {

                        if (yolcular[i] == "E")
                        {
                            koltuk.BackColor = Color.LightBlue; koltuk.Enabled = false;
                        }
                        else if (yolcular[i] == "K")
                        {
                            koltuk.BackColor = Color.LightPink; koltuk.Enabled = false;
                        }
                    }
                    grpbKoltuklar.Controls.Add(koltuk); sutun++; if (onkapi == true)
                    {
                        i += 2;

                    }

                }
                if (i == 25 || i == 24)
                {
                    kapiciz(150, 292, "onkapi", "Kapı");
                }

            }
        }
        private void formTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTel.Text = "";
            txtUcret.Text = "";
            rdoBayan.Checked = false;
            rdoErkek.Checked = false;
            lblSeferTarih.Text = "";
            lblSeferSaat.Text = "";
            comboBoxSefer.DataSource = null;
            comboBoxSefer.Enabled = false;
            comboBoxVaris.DataSource = null;
            comboBoxVaris.Enabled = false;
            comboBoxOSekli.SelectedIndex = -1;
            comboBoxKalkis.SelectedIndex = -1;
            comboBoxVaris.SelectedIndex = -1;

        }

        private void grpbKoltuklar_Enter(object sender, EventArgs e)
        {

        }

        public void kapiciz(int x, int y, string name, string text)
        {
            Button kapi = new Button();
            kapi.Name = name;

            kapi.TabStop = false;
            kapi.Text = text;
            kapi.Size = new System.Drawing.Size(70, 25);
            nokta = new System.Drawing.Point(x, y);
            kapi.Location = nokta;
            kapi.BringToFront();
            kapi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            kapi.Enabled = false;
            kapi.BackColor = Color.Gray;
            grpbKoltuklar.Controls.Add(kapi);
        }
    }
}
