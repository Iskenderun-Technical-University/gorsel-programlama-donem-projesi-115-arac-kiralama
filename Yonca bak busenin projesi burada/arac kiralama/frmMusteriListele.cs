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
    public partial class frmMusteriListele : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            Yenilelistele();
        }

        private void Yenilelistele()
        {
            string cümle = "select * from YMuster";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "AD";
            dataGridView1.Columns[1].HeaderText = "SOYAD";
            dataGridView1.Columns[2].HeaderText = "DOGUMTARİH";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "ADRES";
            dataGridView1.Columns[5].HeaderText = "TEL";
            dataGridView1.Columns[6].HeaderText = "MAİL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from YMuster where tc like'&"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBoxAd.Text = satır.Cells[0].Value.ToString();
            textBoxSoyad.Text = satır.Cells[1].Value.ToString();
            textBoxDogum.Text = satır.Cells[2].Value.ToString();
            textBoxTc.Text = satır.Cells[3].Value.ToString();
            textBoxAdres.Text = satır.Cells[4].Value.ToString();
            textBoxTel.Text = satır.Cells[5].Value.ToString();
            textBoxMail.Text = satır.Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update YMuster set Ad=@Ad,Soyad=@Soyad,DogumTarih=@DogumTarih,Adres=@Adres,Tel=@Tel,Mail=@Mail where TC=@TC";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@DogumTarih", textBoxDogum.Text);
            komut2.Parameters.AddWithValue("@Tc", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            komut2.Parameters.AddWithValue("@Tel", textBoxTel.Text);
            komut2.Parameters.AddWithValue("@mail", textBoxMail.Text);
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Yenilelistele();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cumle = "delete from YMuster where tc='" + satır.Cells["TC"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            //bu üstteki satır isteğe bağlı biraz istersen silebilirsin
            Yenilelistele();
        }
    }
}
