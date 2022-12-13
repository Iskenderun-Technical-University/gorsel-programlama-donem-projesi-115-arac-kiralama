using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arac_kiralama
{
    public partial class FormSözleşme : Form
    {
        public FormSözleşme()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void FormSözleşme_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            string sorgu3 = "select * from YSozlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);


            //comboBoxAraclar.DisplayMember = "Name";
            //comboBoxAraclar.ValueMember = "Name";
            //string sorgu4 = "select Plaka from YKiralama";
            //SqlDataAdapter adtr3 = new SqlDataAdapter();
            //comboBoxAraclar.DataSource = arac.listele(adtr3, sorgu4);


        }

        private void textBoxTc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from YKiralama where Plaka like '" + comboBoxAraclar.SelectedItem + "'";
            arac.CombodanGetir(comboBoxAraclar, textBoxPlaka, textBoxMarka, textBoxModel, textBoxRenk, sorgu2);
        }

        private void comboBoxKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from YKiralama where Plaka like '" + comboBoxAraclar.SelectedItem + "'";
            arac.Ucret_Hesapla(comboBoxKiraSekli, textBoxKiraUcreti, sorgu2);
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDonusTarihi.Text) - DateTime.Parse(dateCikisTarihi.Text);
            int gun2 = gun.Days;
            textBoxGun.Text = gun2.ToString();
            textBoxTutar.Text = (gun2 * int.Parse(textBoxKiraUcreti.Text)).ToString();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {

            this.dateCikisTarihi.Value = DateTime.Now;
            this.dateDonusTarihi.Value = DateTime.Now;


            comboBoxKiraSekli.Text = "";
            textBoxKiraUcreti.Text = "";
            textBoxGun.Text = "";
            textBoxTutar.Text = ";";
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into YSozlesme(Tc,Ad,Soyad,Telefon,EhliyetNo,Plaka,Marka,Model,Renk,KiraSekli,KiraUcret,Gun,Tutar,Ctarih,Dtarih) values(@Tc,@Ad,@Soyad,@Telefon,@EhliyetNo,@Plaka,@Marka,@Model,@Renk,@KiraSekli,@KiraUcret,@Gun,@Tutar,@Ctarih,@Dtarih)";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@EhliyetNo", textBoxEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@Plaka", textBoxPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka", textBoxMarka.Text);
            komut2.Parameters.AddWithValue("@Model", textBoxModel.Text);
            komut2.Parameters.AddWithValue("@Renk", textBoxRenk.Text);
            komut2.Parameters.AddWithValue("@KiraSekli", comboBoxKiraSekli.Text);
            komut2.Parameters.AddWithValue("@KiraUcret", int.Parse(textBoxKiraUcreti.Text));
            komut2.Parameters.AddWithValue("@Gun", int.Parse(textBoxGun.Text));
            komut2.Parameters.AddWithValue("@Tutar", int.Parse(textBoxTutar.Text));
            komut2.Parameters.AddWithValue("@Ctarih", dateCikisTarihi.Text);
            komut2.Parameters.AddWithValue("@Dtarih", dateDonusTarihi.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);
            comboBoxAraclar.Items.Clear();
            Yenile();
           // foreach (Control item in groupBoxMusteriBilgi.Controls) if (item == GetType(TextBox)) item.Text = "";
           // foreach (Control item in groupBoxAracBilgi.Controls) if (item is TextBox) item.Text = "";
            comboBoxAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sozlesme eklendi");

        }

        private void textBoxTcAra_TextChanged(object sender, EventArgs e)
        {
           foreach (Control item in groupBoxAracBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";


            string sorgu2 = "select * from YMuster where Tc like '" + textBoxTcAra.Text + "'";
            arac.Tc_Ara(textBoxTcAra,textBoxTc, textBoxAd, textBoxSoyad, textBoxTelefon, sorgu2);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update YSozlesme set Tc=@Tc,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,EhliyetNo=@EhliyetNo,Marka=@Marka,Model=@Model,Renk=@Renk,KiraSekli=@KiraSekli,KiraUcret=@KiraUcret,Gun=@Gun,Tutar=@Tutar,Ctarih=@Ctarih,Dtarih=@Dtarih where Plaka=@Plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@EhliyetNo", textBoxEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@Plaka", textBoxPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka", textBoxMarka.Text);
            komut2.Parameters.AddWithValue("@Model", textBoxModel.Text);
            komut2.Parameters.AddWithValue("@Renk", textBoxRenk.Text);
            komut2.Parameters.AddWithValue("@KiraSekli", comboBoxKiraSekli.Text);
            komut2.Parameters.AddWithValue("@KiraUcret", int.Parse(textBoxKiraUcreti.Text));
            komut2.Parameters.AddWithValue("@Gun", int.Parse(textBoxGun.Text));
            komut2.Parameters.AddWithValue("@Tutar", int.Parse(textBoxTutar.Text));
            komut2.Parameters.AddWithValue("@Ctarih", dateCikisTarihi.Text);
            komut2.Parameters.AddWithValue("@Dtarih", dateDonusTarihi.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);
            comboBoxAraclar.Items.Clear();
            Yenile();
            foreach (Control item in groupBoxMusteriBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
            foreach (Control item in groupBoxAracBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
            comboBoxAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sozlesme guncellendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBoxTc.Text = satır.Cells[0].Value.ToString();
            textBoxAd.Text = satır.Cells[1].Value.ToString();
            textBoxSoyad.Text = satır.Cells[2].Value.ToString();
            textBoxTelefon.Text = satır.Cells[3].Value.ToString();
            textBoxEhliyetNo.Text = satır.Cells[4].Value.ToString();
            comboBoxAraclar.Text = satır.Cells[5].Value.ToString();
            textBoxMarka.Text = satır.Cells[6].Value.ToString();
            textBoxModel.Text = satır.Cells[7].Value.ToString();
            textBoxRenk.Text = satır.Cells[8].Value.ToString();
            comboBoxKiraSekli.Text = satır.Cells[9].Value.ToString();
            textBoxKiraUcreti.Text = satır.Cells[10].Value.ToString();
            textBoxGun.Text = satır.Cells[11].Value.ToString();
            textBoxTutar.Text = satır.Cells[12].Value.ToString();
            dateCikisTarihi.Text = satır.Cells[13].Value.ToString();
            dateDonusTarihi.Text = satır.Cells[14].ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //Gun farkini Hesapla
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satır.Cells["Dtarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["KiraUcret"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            int _gunfarki = gunfarki.Days;
            int ucretfarki;
            //Ücret farkı hesapla
            ucretfarki = _gunfarki * ucret;
            textBoxEkstra.Text = ucretfarki.ToString();
            //Toplam Tutar Heesapla


        }

        private void buttonAracEkle_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxEkstra.Text)>=0 || int.Parse(textBoxEkstra.Text) < 0)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["KiraUcret"].Value.ToString());
                int tutar = int.Parse(satır.Cells["Tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satır.Cells["Ctarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                //Toplamtutar,_gun ve ucret satıs tablosundan aktarılacak
                string sorgu1 = "delete from YSozlesme where Plaka='"+satır.Cells["Plaka"].Value.ToString()+"'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_güncelle(komut,sorgu1);

                string sorgu3 = "insert into YOKiralama(Tc,Ad,Soyad,Plaka,Marka,Seri,Yıl,Gun,Fiyat,Tutar,Renk,TarihCikis,TarihBugun) values(@Tc,@Ad,@Soyad,@Plaka,@Marka,@Seri,@Yıl,@Gun,@Fiyat,@Tutar,@Renk,@TarihCikis,@TarihBugun)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@Tc", satır.Cells["Tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@Ad", satır.Cells["Ad"].Value.ToString());
                komut2.Parameters.AddWithValue("@Soyad", satır.Cells["Soyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@Plaka", satır.Cells["Plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@Marka", satır.Cells["Marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@Seri", satır.Cells["Seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@Yil", satır.Cells["Yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@Gun", _gun);
                komut2.Parameters.AddWithValue("@Fiyat", ucret);
                komut2.Parameters.AddWithValue("@Tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@Renk", satır.Cells["Renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@TarihCikis", satır.Cells["Ctarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@TarihBugun", DateTime.Now.ToShortDateString());

                arac.ekle_sil_güncelle(komut2, sorgu3);

                MessageBox.Show("Arac Teslim Edildi");
                comboBoxAraclar.Text = "";
                comboBoxAraclar.Items.Clear();
                Yenile();
                foreach (Control item in groupBoxMusteriBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
                foreach (Control item in groupBoxAracBilgi.Controls) if (item.GetType() == typeof(System.Windows.Forms.TextBox)) item.Text = "";
                comboBoxAraclar.Text = "";
                Temizle();
                textBoxEkstra.Text = "";
            }
            else
            {
                MessageBox.Show("lutfen secim yapiniz", "uyari");
            }
        }
    }
}
