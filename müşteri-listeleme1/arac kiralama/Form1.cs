namespace arac_kiralama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void buttonCikis4_Click(object sender, EventArgs e)
        {
            // thisClose;
            DialogResult result1 = MessageBox.Show("Cikmak istdiginize emin miziniz?","",MessageBoxButtons.YesNo);
            if(result1 == DialogResult.Yes)
            {
                Application.Exit();
             }
            else
            {

            }
        }

        private void buttonKayit1_Click(object sender, EventArgs e)
        {
            frmMusterEkle ekle =new frmMusterEkle();
            ekle.ShowDialog();
        }

        private void buttonMusteriListe2_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();

        }
    }
}