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

namespace arac_kiralama
{
    public partial class frmMusterEkle : Form
    {
        //class ı yeniden adlandırdık
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmMusterEkle()
        {
            InitializeComponent();
        }
        //iptal butonu ile formu kapatma işlemi
        private void buttonIptal_Click(object sender, EventArgs e)
        {
            // thisClose;
            DialogResult result1 = MessageBox.Show("Cikmak istdiginize emin miziniz?", "", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }

        }
        //textbox içine yazdığımız verileri veri tabanımızdaki satırlara yazıyoruz
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into YMuster(Ad,Soyad,DogumTarih,TC,Adres,Tel,mail,ehliyetNo) values(@Ad,@Soyad,@DogumTarih,@TC,@Adres,@Tel,@mail,@ehliyetNo)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad",textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@DogumTarih",textBoxDogum.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Adres",textBoxAdres.Text);
            komut2.Parameters.AddWithValue("@Tel", textBoxTel.Text);
            komut2.Parameters.AddWithValue("@mail", textBoxMail.Text);
            komut2.Parameters.AddWithValue("@ehliyetNo", textBoxEhliyetNo.Text);
            arac_kiralama.ekle_sil_güncelle(komut2,cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void frmMusterEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
