using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp3
{

    public partial class HastaRaporVer : Form
    {
        string[] secilenHastaOzellikleri = new string[10];
        List<string> arrayList = new List<string>();
        HastalarVeriTabani hastaKayit3 = new HastalarVeriTabani();
        HastalarVeriTabani hastalarinOgunleri = new HastalarVeriTabani();
        public HastaRaporVer()
        {
            InitializeComponent();
        }

        private void HastaRaporVer_Load(object sender, EventArgs e)
        {
            HastalariCek();
        }
        public void HastaOgunleriniCek()
        {

            DataSet ds = hastalarinOgunleri.HastaOgunleriCek(secilenHastaOzellikleri[6]);
            foreach (DataRow dtRow in ds.Tables[0].Rows)
            {
                for (int i = 0; i < 4; i++)
                {
                    arrayList.Add(dtRow[i].ToString()); // 0 tc 1 sabah 2 oglen 3 aksam diyeti
                }
            }

        }

        public void HastalariCek()
        {
            DataSet veriler = hastaKayit3.HastaCek();
            dtHastalar.DataSource = veriler.Tables[0];
        }

        public void HastalariJsonKaydet()
        {
            HastaCek hasta = new HastaCek
            {

                Ad = secilenHastaOzellikleri[1],
                Soyad = secilenHastaOzellikleri[2],
                HastalikAdi = secilenHastaOzellikleri[3],
                Yas = int.Parse(secilenHastaOzellikleri[4]),
                Kilo = int.Parse(secilenHastaOzellikleri[5]),
                TC = Convert.ToInt64(secilenHastaOzellikleri[6]),
                TelNo = Convert.ToInt64(secilenHastaOzellikleri[7]),
                Tarih = secilenHastaOzellikleri[9],

                DiyetTipi = secilenHastaOzellikleri[8],
                Sabah = arrayList[1].ToString(),
                Ogle = arrayList[2].ToString(),
                Aksam = arrayList[3].ToString(),
            };
            string json = JsonConvert.SerializeObject(hasta, Formatting.Indented);
            File.WriteAllText(@secilenHastaOzellikleri[1] + ".json", json);
        }

        public void HastalariHtmlKaydet()
        {
            string hastaadi = secilenHastaOzellikleri[1];
            string exePath =
        System.IO.Path.GetDirectoryName(
           System.Reflection.Assembly.GetEntryAssembly().Location);
            string dosya_yolu = exePath + "\\" + hastaadi + ".html";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine("<center> <hr> <b> DİYETİSYEN RAPORU </b> </hr> </center> ");
            sw.WriteLine("<b> HASTA ADI: </b> " + hastaadi + "<br>");
            sw.WriteLine("<b> HASTA SOYADI: </b> " + secilenHastaOzellikleri[2] + "<br>");
            sw.WriteLine("<b> HASTALIK: </b> " + secilenHastaOzellikleri[3] + "<br>");
            sw.WriteLine("<b> YAŞ: </b> " + secilenHastaOzellikleri[4] + "<br>");
            sw.WriteLine("<b> KİLO: </b> " + secilenHastaOzellikleri[5] + "<br>");
            sw.WriteLine("<b> TC NO: </b> " + secilenHastaOzellikleri[6] + "<br>");
            sw.WriteLine("<b> Tel No: </b> " + secilenHastaOzellikleri[7] + "<br>");
            sw.WriteLine("<center> <hr> <b> HASTANIN DİYET DETAYLARI </b> </hr> </center> ");
            sw.WriteLine("<b> Diyet: </b> " + secilenHastaOzellikleri[8] + "<br>");
            sw.WriteLine("<b> Diyet Tarihi: </b> " + secilenHastaOzellikleri[9] + "<br>");
            sw.WriteLine("<b> Sabah Öğünü: </b> " + arrayList[1].ToString() + "<br>");
            sw.WriteLine("<b> Öğlen Öğünü: </b> " + arrayList[2].ToString() + "<br>");
            sw.WriteLine("<b> Akşam Öğünü: </b> " + arrayList[3].ToString() + "<br>");
            sw.WriteLine("<center> <hr> <b> RAPORU ÇIKTI ALMAK İÇİN CTRL+P YAPABİLİRSİNİZ. GEÇMİŞ OLSUN.  </b> </hr> </center> ");
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
                }
            }
        }

        private void lblRaporVer_Click(object sender, EventArgs e)
        {
            HastaOgunleriniCek();
            if (cmbDosyaTuru.Text == "HTML")
            {
                HastalariHtmlKaydet();
                MessageBox.Show("HTML türünde rapor hazırlandı...");
            }

            else if (cmbDosyaTuru.Text == "JSON")
            {
                HastalariJsonKaydet();
                MessageBox.Show("JSON türünde rapor hazırlandı...");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            HastaKayitForm hastaKayit = new HastaKayitForm();
            hastaKayit.Show();
        }
    }
}
