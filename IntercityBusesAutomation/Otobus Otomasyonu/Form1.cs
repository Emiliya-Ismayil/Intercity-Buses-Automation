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
    public partial class Form1 : Form
    {
        public static Form1 mdi;
        public Form1()
        {

            InitializeComponent();
        }
        void yavruform(Form yavru)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == yavru.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
                else
                {
                    eleman.Close();
                }
            }
            if (durum == false)
            {
                yavru.MdiParent = this;
                yavru.Show();
            }
        }
        public void menuGizle()
        {
            yönetimselİşlemlerToolStripMenuItem.Enabled = false;
            BiletToolStripMenuItem.Enabled = false;
            oturumuKapatToolStripMenuItem.Enabled = false;
            kullanıcıİşlemleriToolStripMenuItem.Enabled = false;

        }

        private void enAltFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletSatis frm = new BiletSatis();
            yavruform(frm);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otobus fab = new Otobus();
            yavruform(fab);
        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sefer fab = new Sefer();
            yavruform(fab);

        }

        private void şoförlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sofor fab = new Sofor();
            yavruform(fab);
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login(); lblKullanici.Text = "";
            menuGizle();
            yavruform(log);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuGizle();
            Login frm = new Login(); yavruform(frm);
            frm.MdiParent = this;
            mdi = this;


        }

        private void yönetimselİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void biletSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletSil frm = new BiletSil();
            yavruform(frm);
        }

        private void userGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UserEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UserSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userDuzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcılarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanicilar frm = new Kullanicilar();
            yavruform(frm);


        }

        private void ekleSilDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciIslem frm = new KullaniciIslem();
            yavruform(frm);
        }

        private void btCikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Cikmak istediginizden eminmisiniz?", "Uyari!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
