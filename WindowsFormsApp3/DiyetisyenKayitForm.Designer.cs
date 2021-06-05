
namespace WindowsFormsApp3
{
    partial class DiyetisyenKayitForm
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
            this.txtKullaniciTelNo = new System.Windows.Forms.MaskedTextBox();
            this.btnKullaniciKaydet = new System.Windows.Forms.Button();
            this.txtKullaniciTcNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtKullaniciSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtKullanicilar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtKullanicilar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciTelNo
            // 
            this.txtKullaniciTelNo.Location = new System.Drawing.Point(171, 191);
            this.txtKullaniciTelNo.Mask = "00000000000";
            this.txtKullaniciTelNo.Name = "txtKullaniciTelNo";
            this.txtKullaniciTelNo.Size = new System.Drawing.Size(100, 26);
            this.txtKullaniciTelNo.TabIndex = 4;
            // 
            // btnKullaniciKaydet
            // 
            this.btnKullaniciKaydet.Location = new System.Drawing.Point(164, 137);
            this.btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            this.btnKullaniciKaydet.Size = new System.Drawing.Size(74, 30);
            this.btnKullaniciKaydet.TabIndex = 7;
            this.btnKullaniciKaydet.Text = "Kaydet";
            this.btnKullaniciKaydet.UseVisualStyleBackColor = true;
            this.btnKullaniciKaydet.Click += new System.EventHandler(this.btnKullaniciKaydet_Click);
            // 
            // txtKullaniciTcNo
            // 
            this.txtKullaniciTcNo.Location = new System.Drawing.Point(171, 143);
            this.txtKullaniciTcNo.Mask = "00000000000";
            this.txtKullaniciTcNo.Name = "txtKullaniciTcNo";
            this.txtKullaniciTcNo.Size = new System.Drawing.Size(100, 26);
            this.txtKullaniciTcNo.TabIndex = 3;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(19, 194);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(115, 19);
            this.lblTelNo.TabIndex = 19;
            this.lblTelNo.Text = "Telefon Numarası";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(19, 146);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(97, 19);
            this.lblTC.TabIndex = 17;
            this.lblTC.Text = "TC Kimlik No";
            // 
            // txtKullaniciSoyad
            // 
            this.txtKullaniciSoyad.Location = new System.Drawing.Point(171, 97);
            this.txtKullaniciSoyad.Name = "txtKullaniciSoyad";
            this.txtKullaniciSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtKullaniciSoyad.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(19, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 19);
            this.lblSoyad.TabIndex = 15;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(171, 51);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(121, 26);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(19, 54);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(28, 19);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad";
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(117, 42);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(121, 26);
            this.txtKullaniciID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(117, 85);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(121, 26);
            this.txtKullaniciSifre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre";
            // 
            // dtKullanicilar
            // 
            this.dtKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKullanicilar.Location = new System.Drawing.Point(13, 306);
            this.dtKullanicilar.Name = "dtKullanicilar";
            this.dtKullanicilar.Size = new System.Drawing.Size(844, 105);
            this.dtKullanicilar.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txtKullaniciSoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblTelNo);
            this.groupBox1.Controls.Add(this.txtKullaniciTcNo);
            this.groupBox1.Controls.Add(this.txtKullaniciTelNo);
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 232);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKullaniciID);
            this.groupBox2.Controls.Add(this.txtKullaniciSifre);
            this.groupBox2.Controls.Add(this.btnKullaniciKaydet);
            this.groupBox2.Location = new System.Drawing.Point(388, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 223);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.cancel__3_;
            this.pictureBox1.Location = new System.Drawing.Point(833, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Image = global::WindowsFormsApp3.Properties.Resources.left_arrow__1_;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(32, 32);
            this.btnGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnGeri.TabIndex = 38;
            this.btnGeri.TabStop = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // DiyetisyenKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(871, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtKullanicilar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiyetisyenKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiyetisyenKayitForm";
            this.Load += new System.EventHandler(this.DiyetisyenKayitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtKullanicilar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtKullaniciTelNo;
        private System.Windows.Forms.Button btnKullaniciKaydet;
        private System.Windows.Forms.MaskedTextBox txtKullaniciTcNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtKullaniciSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtKullanicilar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnGeri;
    }
}