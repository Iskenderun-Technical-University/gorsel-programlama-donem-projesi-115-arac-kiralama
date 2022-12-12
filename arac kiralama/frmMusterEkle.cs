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
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmMusterEkle()
        {
            InitializeComponent();
        }

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

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into YMuster(Ad,Soyad,DogumTarih,TC,Adres,Tel,mail) values(@Ad,@Soyad,@DogumTarih,@TC,@Adres,@Tel,@mail)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad",textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@DogumTarih",textBoxDogum.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Adres",textBoxAdres.Text);
            komut2.Parameters.AddWithValue("@Tel", textBoxTel.Text);
            komut2.Parameters.AddWithValue("@mail", textBoxMail.Text);
            arac_kiralama.ekle_sil_güncelle(komut2,cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void frmMusterEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
