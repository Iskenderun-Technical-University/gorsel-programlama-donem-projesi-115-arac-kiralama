namespace arac_kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if(m�steriKayitPanel.Visible==true)
            {
                m�steriKayitPanel.Visible = false;
            }
            else
            {
                m�steriKayitPanel.Visible = true;
            }




        }


    }
}