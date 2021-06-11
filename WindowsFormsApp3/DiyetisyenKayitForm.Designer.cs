
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtKullaniciTelNo = new System.Windows.Forms.MaskedTextBox();
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
            this.lblKaydet = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtKullanicilar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciTelNo
            // 
            this.txtKullaniciTelNo.Location = new System.Drawing.Point(171, 191);
            this.txtKullaniciTelNo.Mask = "00000000000";
            this.txtKullaniciTelNo.Name = "txtKullaniciTelNo";
            this.txtKullaniciTelNo.Size = new System.Drawing.Size(100, 35);
            this.txtKullaniciTelNo.TabIndex = 4;
            // 
            // txtKullaniciTcNo
            // 
            this.txtKullaniciTcNo.Location = new System.Drawing.Point(171, 143);
            this.txtKullaniciTcNo.Mask = "00000000000";
            this.txtKullaniciTcNo.Name = "txtKullaniciTcNo";
            this.txtKullaniciTcNo.Size = new System.Drawing.Size(100, 35);
            this.txtKullaniciTcNo.TabIndex = 3;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(19, 194);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(182, 27);
            this.lblTelNo.TabIndex = 19;
            this.lblTelNo.Text = "Telefon Numarası";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(19, 146);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(148, 27);
            this.lblTC.TabIndex = 17;
            this.lblTC.Text = "TC Kimlik No";
            // 
            // txtKullaniciSoyad
            // 
            this.txtKullaniciSoyad.Location = new System.Drawing.Point(171, 97);
            this.txtKullaniciSoyad.Name = "txtKullaniciSoyad";
            this.txtKullaniciSoyad.Size = new System.Drawing.Size(121, 35);
            this.txtKullaniciSoyad.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(19, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(71, 27);
            this.lblSoyad.TabIndex = 15;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(171, 51);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(121, 35);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(19, 54);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(41, 27);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad";
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(135, 42);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(121, 35);
            this.txtKullaniciID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(135, 85);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(121, 35);
            this.txtKullaniciSifre.TabIndex = 6;
            this.txtKullaniciSifre.TextChanged += new System.EventHandler(this.txtKullaniciSifre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre";
            // 
            // dtKullanicilar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dtKullanicilar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtKullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtKullanicilar.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtKullanicilar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtKullanicilar.Location = new System.Drawing.Point(12, 336);
            this.dtKullanicilar.Name = "dtKullanicilar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtKullanicilar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dtKullanicilar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtKullanicilar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtKullanicilar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtKullanicilar.Size = new System.Drawing.Size(855, 105);
            this.dtKullanicilar.TabIndex = 27;
            this.dtKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtKullanicilar_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txtKullaniciSoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblTelNo);
            this.groupBox1.Controls.Add(this.txtKullaniciTcNo);
            this.groupBox1.Controls.Add(this.txtKullaniciTelNo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 232);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblKaydet);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKullaniciID);
            this.groupBox2.Controls.Add(this.txtKullaniciSifre);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(389, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 232);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // lblKaydet
            // 
            this.lblKaydet.AutoSize = true;
            this.lblKaydet.Location = new System.Drawing.Point(201, 145);
            this.lblKaydet.Name = "lblKaydet";
            this.lblKaydet.Size = new System.Drawing.Size(82, 27);
            this.lblKaydet.TabIndex = 7;
            this.lblKaydet.Text = "Kaydet";
            this.lblKaydet.Click += new System.EventHandler(this.lblKaydet_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.download_32px1;
            this.pictureBox3.Location = new System.Drawing.Point(163, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.cancel__3_;
            this.pictureBox1.Location = new System.Drawing.Point(847, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.Image = global::WindowsFormsApp3.Properties.Resources.left_arrow__1_;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(32, 32);
            this.btnGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnGeri.TabIndex = 38;
            this.btnGeri.TabStop = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(206, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(583, 46);
            this.label4.TabIndex = 41;
            this.label4.Text = "DİYETİSYEN BİLGİLERİ KAYIT";
            // 
            // DiyetisyenKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.black_material_ui_background_by_ministerkraft_dddraqt_fullview;
            this.ClientSize = new System.Drawing.Size(884, 464);
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtKullaniciTelNo;
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
        private System.Windows.Forms.Label lblKaydet;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}