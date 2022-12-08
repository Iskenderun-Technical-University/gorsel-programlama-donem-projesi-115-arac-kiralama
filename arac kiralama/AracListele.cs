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
    public partial class AracListele : Form
    {
        Arac_Kiralama arac_Kiralama = new Arac_Kiralama();
        public AracListele()
        {
            InitializeComponent();
        }

        private void textBoxKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxYakit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBoxPlaka.Text = satir.Cells["plaka"].Value.ToString();
            comboBoxMarka.Text = satir.Cells["marka"].Value.ToString();
            comboBoxModel.Text = satir.Cells["model"].Value.ToString();
            textBoxKm.Text = satir.Cells["kilometre"].Value.ToString();
            textBoxRenk.Text = satir.Cells["renk"].Value.ToString();
            comboBoxYakit.Text = satir.Cells["yakıt"].Value.ToString();
            textBoxKiralamaUcret.Text = satir.Cells["ücret"].Value.ToString();

        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            YenileAracListele();
        }

        private void YenileAracListele()
        {
            string cumle = "select * from YKiralama";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac_Kiralama.listele(adtr2, cumle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            string cumle = "update YKiralama set Marka=@Marka,Model=@Model,KM=@KM,Renk=@Renk,Yakit=@Yakit,KiraUcreti=@KiraUcreti,Resim=@Resim";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Plaka", textBoxPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka", comboBoxMarka.Text);
            komut2.Parameters.AddWithValue("@Model", comboBoxModel.Text);
            komut2.Parameters.AddWithValue("@KM", textBoxKm.Text);
            komut2.Parameters.AddWithValue("@Renk", textBoxRenk.Text);
            komut2.Parameters.AddWithValue("@Yakit", comboBoxYakit.Text);
            komut2.Parameters.AddWithValue("@KiraUcreti", int.Parse(textBoxKiralamaUcret.Text));
            komut2.Parameters.AddWithValue("@Resim", pictureBox2.ImageLocation);
            arac_Kiralama.ekle_sil_güncelle(komut2, cumle);
            comboBoxModel.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileAracListele();
            pictureBox2.Image = null;
            pictureBox2.Invalidate();
            comboBoxModel.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void buttonResim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if(satir!=null)
            {
            string cumle = "delete from YKiralama where Plaka='" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
                arac_Kiralama.ekle_sil_güncelle(komut2, cumle);
            YenileAracListele();
            }
        }

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
                else if (comboBoxMarka.SelectedIndex == 1)
                {
                    comboBoxModel.Items.Add("Camaro");
                    comboBoxModel.Items.Add("Corvette");

                }
                else if (comboBoxMarka.SelectedIndex == 2)
                {
                    comboBoxModel.Items.Add("Gran Turismo");
                    comboBoxModel.Items.Add("Ghibli");

                }
                else if (comboBoxMarka.SelectedIndex == 3)
                {
                    comboBoxModel.Items.Add("db11");
                    comboBoxModel.Items.Add("v12");
                }
                else if (comboBoxMarka.SelectedIndex == 4)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
