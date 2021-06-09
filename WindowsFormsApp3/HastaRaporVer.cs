using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp3
{

    public partial class HastaRaporVer : Form
    {
        string[] secilenHastaOzellikleri = new string [10];
        
        
        HastalarVeriTabani hastaKayit3 = new HastalarVeriTabani();
        public HastaRaporVer()
        {
            InitializeComponent();
        }

        private void HastaRaporVer_Load(object sender, EventArgs e)
        {
            HastalariCek();
        }

        public void HastalariCek()
        {
            
            DataSet veriler = hastaKayit3.HastaCek();
            dtHastalar.DataSource = veriler.Tables[0];
           

    

            //cmbHastaID.DataSource = veriler.Tables[0];
            //cmbHastaID.ValueMember = "HastaTC";
            //cmbHastaID.DisplayMember = "HastaTC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
          
            int hastaID;
            string hastaName;
       


            if (cmbDosyaTuru.Text=="HTML")
            {
                for (int i = 1; i < secilenHastaOzellikleri.Length; i++)
                {
                    MessageBox.Show("Hasta :" + secilenHastaOzellikleri[i]);

                }
            }

            else if (cmbDosyaTuru.Text == "JSON")
            {

            }
        }

        public void HastalariHtmlKaydet()
        {


        }

        private void dtHastalar_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtHastalar.SelectedRows)
            {

                for (int i = 1; i < secilenHastaOzellikleri.Length; i++) //tüm hastaları diziye çektik
                {
                    secilenHastaOzellikleri[i] = row.Cells[i].Value.ToString();
                   // MessageBox.Show("Hasta :" + secilenHastaOzellikleri[i]);
                }
              
            }
        }
    }
}
