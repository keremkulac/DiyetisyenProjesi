
namespace WindowsFormsApp3
{
    partial class HastaRaporVer
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
            this.lblDosyaTuru = new System.Windows.Forms.Label();
            this.cmbDosyaTuru = new System.Windows.Forms.ComboBox();
            this.dtHastalar = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDosyaTuru
            // 
            this.lblDosyaTuru.AutoSize = true;
            this.lblDosyaTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaTuru.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDosyaTuru.Location = new System.Drawing.Point(45, 281);
            this.lblDosyaTuru.Name = "lblDosyaTuru";
            this.lblDosyaTuru.Size = new System.Drawing.Size(103, 21);
            this.lblDosyaTuru.TabIndex = 42;
            this.lblDosyaTuru.Text = "Dosya Türü:";
            // 
            // cmbDosyaTuru
            // 
            this.cmbDosyaTuru.FormattingEnabled = true;
            this.cmbDosyaTuru.Items.AddRange(new object[] {
            "HTML",
            "JSON"});
            this.cmbDosyaTuru.Location = new System.Drawing.Point(154, 273);
            this.cmbDosyaTuru.Name = "cmbDosyaTuru";
            this.cmbDosyaTuru.Size = new System.Drawing.Size(120, 29);
            this.cmbDosyaTuru.TabIndex = 41;
            // 
            // dtHastalar
            // 
            this.dtHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHastalar.Location = new System.Drawing.Point(21, 69);
            this.dtHastalar.Name = "dtHastalar";
            this.dtHastalar.RowHeadersWidth = 51;
            this.dtHastalar.RowTemplate.Height = 24;
            this.dtHastalar.Size = new System.Drawing.Size(876, 168);
            this.dtHastalar.TabIndex = 46;
            this.dtHastalar.SelectionChanged += new System.EventHandler(this.dtHastalar_SelectionChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.icons8_document_30;
            this.pictureBox3.Location = new System.Drawing.Point(337, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(386, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Rapor Ver";
            this.label1.Click += new System.EventHandler(this.lblRaporVer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.cancel__3_;
            this.pictureBox1.Location = new System.Drawing.Point(879, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.Image = global::WindowsFormsApp3.Properties.Resources.left_arrow__1_;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(32, 32);
            this.btnGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnGeri.TabIndex = 49;
            this.btnGeri.TabStop = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(284, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 36);
            this.label4.TabIndex = 51;
            this.label4.Text = "HASTA RAPORU ALMA";
            // 
            // HastaRaporVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.black_material_ui_background_by_ministerkraft_dddraqt_fullview;
            this.ClientSize = new System.Drawing.Size(914, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dtHastalar);
            this.Controls.Add(this.lblDosyaTuru);
            this.Controls.Add(this.cmbDosyaTuru);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaRaporVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporVer";
            this.Load += new System.EventHandler(this.HastaRaporVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDosyaTuru;
        private System.Windows.Forms.ComboBox cmbDosyaTuru;
        private System.Windows.Forms.DataGridView dtHastalar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnGeri;
        private System.Windows.Forms.Label label4;
    }
}