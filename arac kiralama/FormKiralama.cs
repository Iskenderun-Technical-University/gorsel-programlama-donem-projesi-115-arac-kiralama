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
    public partial class FormKiralama : Form
    {
        public FormKiralama()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void FormKiralama_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from YOKiralama";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2,sorgu2);
            arac.kiralamahesapla(label1);
        }
    }
}
