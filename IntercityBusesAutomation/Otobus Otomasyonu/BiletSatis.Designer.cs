namespace Tur
{
    partial class BiletSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletSatis));
            this.grpbKoltuklar = new System.Windows.Forms.GroupBox();
            this.grpbYolcuBilgi = new System.Windows.Forms.GroupBox();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.rdoBayan = new System.Windows.Forms.RadioButton();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbSefer = new System.Windows.Forms.GroupBox();
            this.lblSeferSaat = new System.Windows.Forms.Label();
            this.lblSeferTarih = new System.Windows.Forms.Label();
            this.comboBoxSefer = new System.Windows.Forms.ComboBox();
            this.comboBoxVaris = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxKalkis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxOSekli = new System.Windows.Forms.ComboBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpbYolcuBilgi.SuspendLayout();
            this.grpbSefer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbKoltuklar
            // 
            this.grpbKoltuklar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grpbKoltuklar.Location = new System.Drawing.Point(557, 15);
            this.grpbKoltuklar.Margin = new System.Windows.Forms.Padding(4);
            this.grpbKoltuklar.Name = "grpbKoltuklar";
            this.grpbKoltuklar.Padding = new System.Windows.Forms.Padding(4);
            this.grpbKoltuklar.Size = new System.Drawing.Size(409, 694);
            this.grpbKoltuklar.TabIndex = 0;
            this.grpbKoltuklar.TabStop = false;
            this.grpbKoltuklar.Text = "Koltuklar";
            this.grpbKoltuklar.Enter += new System.EventHandler(this.grpbKoltuklar_Enter);
            // 
            // grpbYolcuBilgi
            // 
            this.grpbYolcuBilgi.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grpbYolcuBilgi.Controls.Add(this.rdoErkek);
            this.grpbYolcuBilgi.Controls.Add(this.rdoBayan);
            this.grpbYolcuBilgi.Controls.Add(this.txtTel);
            this.grpbYolcuBilgi.Controls.Add(this.txtSoyad);
            this.grpbYolcuBilgi.Controls.Add(this.txtAd);
            this.grpbYolcuBilgi.Controls.Add(this.label3);
            this.grpbYolcuBilgi.Controls.Add(this.label2);
            this.grpbYolcuBilgi.Controls.Add(this.label1);
            this.grpbYolcuBilgi.Location = new System.Drawing.Point(0, 15);
            this.grpbYolcuBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.grpbYolcuBilgi.Name = "grpbYolcuBilgi";
            this.grpbYolcuBilgi.Padding = new System.Windows.Forms.Padding(4);
            this.grpbYolcuBilgi.Size = new System.Drawing.Size(267, 261);
            this.grpbYolcuBilgi.TabIndex = 1;
            this.grpbYolcuBilgi.TabStop = false;
            this.grpbYolcuBilgi.Text = "Yolcu Bilgileri";
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(111, 166);
            this.rdoErkek.Margin = new System.Windows.Forms.Padding(4);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(65, 21);
            this.rdoErkek.TabIndex = 8;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // rdoBayan
            // 
            this.rdoBayan.AutoSize = true;
            this.rdoBayan.Location = new System.Drawing.Point(29, 166);
            this.rdoBayan.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBayan.Name = "rdoBayan";
            this.rdoBayan.Size = new System.Drawing.Size(69, 21);
            this.rdoBayan.TabIndex = 7;
            this.rdoBayan.TabStop = true;
            this.rdoBayan.Text = "Bayan";
            this.rdoBayan.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(88, 124);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 22);
            this.txtTel.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(88, 82);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(88, 49);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // grpbSefer
            // 
            this.grpbSefer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grpbSefer.Controls.Add(this.lblSeferSaat);
            this.grpbSefer.Controls.Add(this.lblSeferTarih);
            this.grpbSefer.Controls.Add(this.comboBoxSefer);
            this.grpbSefer.Controls.Add(this.comboBoxVaris);
            this.grpbSefer.Controls.Add(this.label6);
            this.grpbSefer.Controls.Add(this.label5);
            this.grpbSefer.Controls.Add(this.label8);
            this.grpbSefer.Controls.Add(this.label4);
            this.grpbSefer.Controls.Add(this.label7);
            this.grpbSefer.Controls.Add(this.comboBoxKalkis);
            this.grpbSefer.Location = new System.Drawing.Point(275, 15);
            this.grpbSefer.Margin = new System.Windows.Forms.Padding(4);
            this.grpbSefer.Name = "grpbSefer";
            this.grpbSefer.Padding = new System.Windows.Forms.Padding(4);
            this.grpbSefer.Size = new System.Drawing.Size(267, 261);
            this.grpbSefer.TabIndex = 2;
            this.grpbSefer.TabStop = false;
            this.grpbSefer.Text = "Sefer Bilgileri";
            // 
            // lblSeferSaat
            // 
            this.lblSeferSaat.AutoSize = true;
            this.lblSeferSaat.Location = new System.Drawing.Point(97, 198);
            this.lblSeferSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeferSaat.Name = "lblSeferSaat";
            this.lblSeferSaat.Size = new System.Drawing.Size(0, 17);
            this.lblSeferSaat.TabIndex = 7;
            // 
            // lblSeferTarih
            // 
            this.lblSeferTarih.AutoSize = true;
            this.lblSeferTarih.Location = new System.Drawing.Point(97, 171);
            this.lblSeferTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeferTarih.Name = "lblSeferTarih";
            this.lblSeferTarih.Size = new System.Drawing.Size(0, 17);
            this.lblSeferTarih.TabIndex = 6;
            // 
            // comboBoxSefer
            // 
            this.comboBoxSefer.Enabled = false;
            this.comboBoxSefer.FormattingEnabled = true;
            this.comboBoxSefer.Location = new System.Drawing.Point(97, 123);
            this.comboBoxSefer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSefer.Name = "comboBoxSefer";
            this.comboBoxSefer.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSefer.TabIndex = 5;
            this.comboBoxSefer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSefer_SelectionChangeCommitted);
            // 
            // comboBoxVaris
            // 
            this.comboBoxVaris.Enabled = false;
            this.comboBoxVaris.FormattingEnabled = true;
            this.comboBoxVaris.Location = new System.Drawing.Point(97, 82);
            this.comboBoxVaris.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVaris.Name = "comboBoxVaris";
            this.comboBoxVaris.Size = new System.Drawing.Size(160, 24);
            this.comboBoxVaris.TabIndex = 4;
            this.comboBoxVaris.SelectionChangeCommitted += new System.EventHandler(this.comboBoxVaris_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sefer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Varış :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kalkış :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarih :";
            // 
            // comboBoxKalkis
            // 
            this.comboBoxKalkis.FormattingEnabled = true;
            this.comboBoxKalkis.Location = new System.Drawing.Point(97, 46);
            this.comboBoxKalkis.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKalkis.Name = "comboBoxKalkis";
            this.comboBoxKalkis.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKalkis.TabIndex = 0;
            this.comboBoxKalkis.SelectionChangeCommitted += new System.EventHandler(this.comboBoxKalkis_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBoxOSekli);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(0, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(520, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "TL";
            // 
            // comboBoxOSekli
            // 
            this.comboBoxOSekli.FormattingEnabled = true;
            this.comboBoxOSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.comboBoxOSekli.Location = new System.Drawing.Point(156, 39);
            this.comboBoxOSekli.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOSekli.Name = "comboBoxOSekli";
            this.comboBoxOSekli.Size = new System.Drawing.Size(160, 24);
            this.comboBoxOSekli.TabIndex = 5;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(156, 89);
            this.txtUcret.Margin = new System.Windows.Forms.Padding(4);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(64, 22);
            this.txtUcret.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ücret :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ödeme Şekli :";
            // 
            // BiletSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbSefer);
            this.Controls.Add(this.grpbYolcuBilgi);
            this.Controls.Add(this.grpbKoltuklar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BiletSatis";
            this.Text = "BiletSatis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BiletSatis_Load);
            this.grpbYolcuBilgi.ResumeLayout(false);
            this.grpbYolcuBilgi.PerformLayout();
            this.grpbSefer.ResumeLayout(false);
            this.grpbSefer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbKoltuklar;
        private System.Windows.Forms.GroupBox grpbYolcuBilgi;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.RadioButton rdoBayan;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbSefer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKalkis;
        private System.Windows.Forms.ComboBox comboBoxSefer;
        private System.Windows.Forms.ComboBox comboBoxVaris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxOSekli;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblSeferSaat;
        private System.Windows.Forms.Label lblSeferTarih;
        private System.Windows.Forms.Label label11;
    }
}