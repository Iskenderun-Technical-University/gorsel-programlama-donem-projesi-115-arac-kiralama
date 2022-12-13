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
    public partial class frmAracKayit : Form
    {
        Arac_Kiralama arac_Kiralama = new Arac_Kiralama();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void buttonResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
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


        /*Try - Catch kullanarak programın çalışması esnasında bir hata oluşması durumunda bizim belirttiğimiz işlemlerin yapılmasını sağlayabiliriz.
         * Bu sayede kullanıcı karışık ve istenmeyen hata sayfalarını görmemiş olur.
         * Ayrıca oluşan hatanın türünü elde edip,hata türüne göre farklı işlemlerin yapılmasını da sağlayabiliriz.
         */
        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                comboBoxModel.Items.Clear();
                if (comboBoxMarka.SelectedItem.ToString() == "Tesla")
                {
                    comboBoxModel.Items.Add("X");
                    comboBoxModel.Items.Add("S");
                }
                else if(comboBoxMarka.SelectedIndex == 1)
                {
                    comboBoxModel.Items.Add("Camaro");
                    comboBoxModel.Items.Add("Corvette");

                }
                else if (comboBoxMarka.SelectedIndex == 2)
                {
                    comboBoxModel.Items.Add("Gran Turismo");
                    comboBoxModel.Items.Add("Ghibli");

                }
                else if(comboBoxMarka.SelectedIndex ==3)
                {
                    comboBoxModel.Items.Add("db11");
                    comboBoxModel.Items.Add("v12");
                }
                else if(comboBoxMarka.SelectedIndex == 4)
                {
                    comboBoxModel.Items.Add("e");
                    comboBoxModel.Items.Add("g");
                }

                else if (comboBoxMarka.SelectedIndex == 5)
                {
                    comboBoxModel.Items.Add("rs7");
                    comboBoxModel.Items.Add("a4");
                }
                else if (comboBoxMarka.SelectedIndex == 6)
                {
                    comboBoxModel.Items.Add("m8");
                    comboBoxModel.Items.Add("4coupe");
                }
                else if (comboBoxMarka.SelectedIndex == 7)
                {
                    comboBoxModel.Items.Add("s90");
                    comboBoxModel.Items.Add("xc40");
                }

                else if (comboBoxMarka.SelectedIndex == 8)
                {
                    comboBoxModel.Items.Add("mx5");  
                }

                else if (comboBoxMarka.SelectedIndex == 9)
                {
                    comboBoxModel.Items.Add("Giulia");
                    comboBoxModel.Items.Add("Tonale");
                }
                else if (comboBoxMarka.SelectedIndex == 10)
                {
                    comboBoxModel.Items.Add("Mustang");
                }
                else if (comboBoxMarka.SelectedIndex == 11)
                {
                    comboBoxModel.Items.Add("Renegade");
                    comboBoxModel.Items.Add("Avenger");
                }


            }

            catch
            {
                ;
            }

        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            string cumle = "insert into YKiralama(Plaka,Marka,Model,KM,Renk,Yakit,KiraUcreti,Resim) values(@Plaka,@Marka,@Model,@KM,@Renk,@Yakit,@KiraUcreti,@Resim)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Plaka", textBoxPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka",comboBoxMarka.Text);
            komut2.Parameters.AddWithValue("@Model", comboBoxModel.Text);
            komut2.Parameters.AddWithValue("@KM", textBoxKm.Text);
            komut2.Parameters.AddWithValue("@Renk", textBoxRenk.Text);
            komut2.Parameters.AddWithValue("@Yakit", comboBoxYakit.Text);
            komut2.Parameters.AddWithValue("@KiraUcreti", int.Parse(textBoxKiralamaUcret.Text));
            komut2.Parameters.AddWithValue("@Resim", pictureBox1.ImageLocation);
            arac_Kiralama.ekle_sil_güncelle(komut2, cumle);
            comboBoxModel.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Invalidate();

        }

        private void frmAracKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
