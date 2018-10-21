namespace Tur
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BiletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletSatisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimselİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şoförlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleSilDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btCikis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BiletToolStripMenuItem,
            this.yönetimselİşlemlerToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.oturumuKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // BiletToolStripMenuItem
            // 
            this.BiletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletSatisToolStripMenuItem,
            this.biletSilToolStripMenuItem});
            this.BiletToolStripMenuItem.Name = "BiletToolStripMenuItem";
            this.BiletToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.BiletToolStripMenuItem.Text = "Bilet İşlemleri";
            // 
            // biletSatisToolStripMenuItem
            // 
            this.biletSatisToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.biletSatisToolStripMenuItem.Name = "biletSatisToolStripMenuItem";
            this.biletSatisToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.biletSatisToolStripMenuItem.Text = "Satış";
            this.biletSatisToolStripMenuItem.Click += new System.EventHandler(this.enAltFormToolStripMenuItem_Click);
            // 
            // biletSilToolStripMenuItem
            // 
            this.biletSilToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.biletSilToolStripMenuItem.Name = "biletSilToolStripMenuItem";
            this.biletSilToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.biletSilToolStripMenuItem.Text = "Sil";
            this.biletSilToolStripMenuItem.Click += new System.EventHandler(this.biletSilToolStripMenuItem_Click);
            // 
            // yönetimselİşlemlerToolStripMenuItem
            // 
            this.yönetimselİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferlerToolStripMenuItem,
            this.otobüslerToolStripMenuItem,
            this.şoförlerToolStripMenuItem});
            this.yönetimselİşlemlerToolStripMenuItem.Name = "yönetimselİşlemlerToolStripMenuItem";
            this.yönetimselİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.yönetimselİşlemlerToolStripMenuItem.Text = "Yönetimsel İşlemler";
            this.yönetimselİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.yönetimselİşlemlerToolStripMenuItem_Click);
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            this.seferlerToolStripMenuItem.Click += new System.EventHandler(this.seferlerToolStripMenuItem_Click);
            // 
            // otobüslerToolStripMenuItem
            // 
            this.otobüslerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.otobüslerToolStripMenuItem.Name = "otobüslerToolStripMenuItem";
            this.otobüslerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.otobüslerToolStripMenuItem.Text = "Otobüsler";
            this.otobüslerToolStripMenuItem.Click += new System.EventHandler(this.otobüslerToolStripMenuItem_Click);
            // 
            // şoförlerToolStripMenuItem
            // 
            this.şoförlerToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.şoförlerToolStripMenuItem.Name = "şoförlerToolStripMenuItem";
            this.şoförlerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.şoförlerToolStripMenuItem.Text = "Şoförler";
            this.şoförlerToolStripMenuItem.Click += new System.EventHandler(this.şoförlerToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarıListeleToolStripMenuItem,
            this.ekleSilDüzenleToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // kullanıcılarıListeleToolStripMenuItem
            // 
            this.kullanıcılarıListeleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.kullanıcılarıListeleToolStripMenuItem.Name = "kullanıcılarıListeleToolStripMenuItem";
            this.kullanıcılarıListeleToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.kullanıcılarıListeleToolStripMenuItem.Text = "Kullanıcıları Listele";
            this.kullanıcılarıListeleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıListeleToolStripMenuItem_Click);
            // 
            // ekleSilDüzenleToolStripMenuItem
            // 
            this.ekleSilDüzenleToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ekleSilDüzenleToolStripMenuItem.Name = "ekleSilDüzenleToolStripMenuItem";
            this.ekleSilDüzenleToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.ekleSilDüzenleToolStripMenuItem.Text = "Ekle/Sil/Düzenle";
            this.ekleSilDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ekleSilDüzenleToolStripMenuItem_Click);
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            this.oturumuKapatToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            this.oturumuKapatToolStripMenuItem.Click += new System.EventHandler(this.oturumuKapatToolStripMenuItem_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblKullanici.Location = new System.Drawing.Point(796, 7);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 17);
            this.lblKullanici.TabIndex = 3;
            // 
            // btCikis
            // 
            this.btCikis.AccessibleName = "btRaporlar";
            this.btCikis.BackColor = System.Drawing.Color.Transparent;
            this.btCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCikis.BackgroundImage")));
            this.btCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCikis.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCikis.ForeColor = System.Drawing.Color.Black;
            this.btCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCikis.Location = new System.Drawing.Point(12, 654);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(93, 82);
            this.btCikis.TabIndex = 11;
            this.btCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCikis.UseVisualStyleBackColor = false;
            this.btCikis.Click += new System.EventHandler(this.btCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 763);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem BiletToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yönetimselİşlemlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem oturumuKapatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem biletSatisToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem biletSilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem otobüslerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem şoförlerToolStripMenuItem;
        public System.Windows.Forms.Label lblKullanici;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kullanıcılarıListeleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ekleSilDüzenleToolStripMenuItem;
        private System.Windows.Forms.Button btCikis;
    }
}
