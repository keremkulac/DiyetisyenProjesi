
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtHastalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDosyaTuru
            // 
            this.lblDosyaTuru.AutoSize = true;
            this.lblDosyaTuru.Location = new System.Drawing.Point(189, 315);
            this.lblDosyaTuru.Name = "lblDosyaTuru";
            this.lblDosyaTuru.Size = new System.Drawing.Size(86, 17);
            this.lblDosyaTuru.TabIndex = 42;
            this.lblDosyaTuru.Text = "Dosya Türü:";
            // 
            // cmbDosyaTuru
            // 
            this.cmbDosyaTuru.FormattingEnabled = true;
            this.cmbDosyaTuru.Items.AddRange(new object[] {
            "HTML",
            "JSON"});
            this.cmbDosyaTuru.Location = new System.Drawing.Point(305, 308);
            this.cmbDosyaTuru.Name = "cmbDosyaTuru";
            this.cmbDosyaTuru.Size = new System.Drawing.Size(180, 24);
            this.cmbDosyaTuru.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Rapor ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtHastalar
            // 
            this.dtHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHastalar.Location = new System.Drawing.Point(28, 47);
            this.dtHastalar.Name = "dtHastalar";
            this.dtHastalar.RowHeadersWidth = 51;
            this.dtHastalar.RowTemplate.Height = 24;
            this.dtHastalar.Size = new System.Drawing.Size(709, 242);
            this.dtHastalar.TabIndex = 46;
            this.dtHastalar.SelectionChanged += new System.EventHandler(this.dtHastalar_SelectionChanged);
            // 
            // HastaRaporVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 437);
            this.Controls.Add(this.dtHastalar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDosyaTuru);
            this.Controls.Add(this.cmbDosyaTuru);
            this.Name = "HastaRaporVer";
            this.Text = "RaporVer";
            this.Load += new System.EventHandler(this.HastaRaporVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDosyaTuru;
        private System.Windows.Forms.ComboBox cmbDosyaTuru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtHastalar;
    }
}