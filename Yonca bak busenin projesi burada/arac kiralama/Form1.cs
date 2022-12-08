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

        private void buttonAracKayit5_Click(object sender, EventArgs e)
        {
            frmAracKayit kayit = new frmAracKayit();
            kayit.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void buttonAracListe3_Click(object sender, EventArgs e)
        {
            AracListele listele2 = new AracListele();
            listele2.ShowDialog();
        }
    }
}