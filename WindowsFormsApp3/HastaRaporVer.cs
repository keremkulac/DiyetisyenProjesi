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
                
                HastalariHtmlKaydet();

                 
                //for (int i = 1; i < secilenHastaOzellikleri.Length; i++)
                //{
                //    MessageBox.Show("Hasta :" + secilenHastaOzellikleri[i]);

                //}
            }

            else if (cmbDosyaTuru.Text == "JSON")
            {

            }
        }

     

        public void HastalariHtmlKaydet()
        {
            string hastaadi = secilenHastaOzellikleri[1];
            MessageBox.Show("HASTA ADI TEST : "+hastaadi);
            string exePath =
        System.IO.Path.GetDirectoryName(
           System.Reflection.Assembly.GetEntryAssembly().Location);
            string dosya_yolu = exePath+ "\\"+hastaadi+".html";


            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine("<center> <hr> <b> DİYETİSYEN RAPORU </b> </hr> </center> ");


            sw.WriteLine("<b> HASTA ADI: </b> "+hastaadi+ "<br>");
            sw.WriteLine("<b> HASTA SOYADI: </b> "+ secilenHastaOzellikleri[2] + "<br>");
            sw.WriteLine("<b> HASTALIK: </b> "+ secilenHastaOzellikleri[3] + "<br>");
            sw.WriteLine("<b> YAŞ: </b> "+ secilenHastaOzellikleri[4] + "<br>");
            sw.WriteLine("<b> KİLO: </b> "+ secilenHastaOzellikleri[5] + "<br>");
            sw.WriteLine("<b> TC NO: </b> "+ secilenHastaOzellikleri[6] + "<br>");
            sw.WriteLine("<b> Tel No: </b> "+ secilenHastaOzellikleri[7] + "<br>");
            sw.WriteLine("<b> Diyet: </b> "+ secilenHastaOzellikleri[8] + "<br>");
            sw.WriteLine("<b> Diyet Tarihi: </b> "+ secilenHastaOzellikleri[9] + "<br>");

            sw.WriteLine("<center> <hr> <b> RAPORU ÇIKTI ALMAK İÇİN CTRL+F YAPABİLİRSİNİZ. GEÇMİŞ OLSUN.  </b> </hr> </center> ");

            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
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
