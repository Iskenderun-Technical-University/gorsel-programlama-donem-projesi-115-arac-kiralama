using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama
{
    internal class Arac_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=YOaracKiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void Tc_Ara(TextBox TcAra,TextBox Tc, TextBox Ad, TextBox Soyad, TextBox Telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Tc.Text = read["Tc"].ToString();
                Ad.Text = read["Ad"].ToString();
                Soyad.Text = read["Soyad"].ToString();
                Telefon.Text = read["Tel"].ToString();
            }
            baglanti.Close();
        }
        public void Ucret_Hesapla(ComboBox comboKiraSekli, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboKiraSekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["KiraUcret"].ToString()) * 1).ToString();
                if (comboKiraSekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["KiraUcret"].ToString()) * 0.80).ToString();
                if (comboKiraSekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["KiraUcret"].ToString()) * 0.70).ToString();

            }
            baglanti.Close();
        }

        public void CombodanGetir(ComboBox Araçlar, TextBox Plaka, TextBox Marka, TextBox Model, TextBox Renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Plaka.Text = read["Plaka"].ToString();
                Marka.Text = read["Marka"].ToString();
                Model.Text = read["Model"].ToString();
                Renk.Text = read["Renk"].ToString();

            }
            baglanti.Close();
        }

        public void kiralamahesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from YOKiralama",baglanti);
            lbl.Text = "Toplam Tutar=" + komut.ExecuteScalar()+" TL ";
            baglanti.Close();
        }
    }
}
