namespace arac_kiralama
{
    partial class AracListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonResim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonIptal = new System.Windows.Forms.Button();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.labelYakit = new System.Windows.Forms.Label();
            this.labelRenk = new System.Windows.Forms.Label();
            this.labelKiralamaUc = new System.Windows.Forms.Label();
            this.labelMara = new System.Windows.Forms.Label();
            this.labelPlaka = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxYakit = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.textBoxKiralamaUcret = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.textBoxRenk = new System.Windows.Forms.TextBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 304);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonResim
            // 
            this.buttonResim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResim.ImageIndex = 1;
            this.buttonResim.ImageList = this.ımageList1;
            this.buttonResim.Location = new System.Drawing.Point(607, 232);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(70, 48);
            this.buttonResim.TabIndex = 37;
            this.buttonResim.Text = "Sil";
            this.buttonResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "refresh (1).png");
            this.ımageList1.Images.SetKeyName(1, "bin.png");
            this.ımageList1.Images.SetKeyName(2, "cancel.png");
            this.ımageList1.Images.SetKeyName(3, "gallery.png");
            this.ımageList1.Images.SetKeyName(4, "image.png");
            // 
            // buttonIptal
            // 
            this.buttonIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIptal.ImageIndex = 2;
            this.buttonIptal.ImageList = this.ımageList1;
            this.buttonIptal.Location = new System.Drawing.Point(481, 232);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(99, 48);
            this.buttonIptal.TabIndex = 36;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(31, 160);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(75, 25);
            this.labelModel.TabIndex = 33;
            this.labelModel.Text = "Model :";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKm.Location = new System.Drawing.Point(6, 229);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(103, 25);
            this.labelKm.TabIndex = 32;
            this.labelKm.Text = "Kilometre :";
            // 
            // labelYakit
            // 
            this.labelYakit.AutoSize = true;
            this.labelYakit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYakit.Location = new System.Drawing.Point(427, 101);
            this.labelYakit.Name = "labelYakit";
            this.labelYakit.Size = new System.Drawing.Size(59, 25);
            this.labelYakit.TabIndex = 31;
            this.labelYakit.Text = "Yakit :";
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRenk.Location = new System.Drawing.Point(426, 33);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(62, 25);
            this.labelRenk.TabIndex = 30;
            this.labelRenk.Text = "Renk :";
            // 
            // labelKiralamaUc
            // 
            this.labelKiralamaUc.AutoSize = true;
            this.labelKiralamaUc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKiralamaUc.Location = new System.Drawing.Point(350, 164);
            this.labelKiralamaUc.Name = "labelKiralamaUc";
            this.labelKiralamaUc.Size = new System.Drawing.Size(142, 25);
            this.labelKiralamaUc.TabIndex = 29;
            this.labelKiralamaUc.Text = "Kıralama Ücret :";
            // 
            // labelMara
            // 
            this.labelMara.AutoSize = true;
            this.labelMara.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMara.Location = new System.Drawing.Point(31, 101);
            this.labelMara.Name = "labelMara";
            this.labelMara.Size = new System.Drawing.Size(72, 25);
            this.labelMara.TabIndex = 28;
            this.labelMara.Text = "Marka :";
            // 
            // labelPlaka
            // 
            this.labelPlaka.AutoSize = true;
            this.labelPlaka.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlaka.Location = new System.Drawing.Point(39, 33);
            this.labelPlaka.Name = "labelPlaka";
            this.labelPlaka.Size = new System.Drawing.Size(64, 25);
            this.labelPlaka.TabIndex = 27;
            this.labelPlaka.Text = "Plaka :";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(117, 156);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(201, 31);
            this.comboBoxModel.TabIndex = 26;
            // 
            // comboBoxYakit
            // 
            this.comboBoxYakit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxYakit.FormattingEnabled = true;
            this.comboBoxYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg",
            "Lityum batarya"});
            this.comboBoxYakit.Location = new System.Drawing.Point(509, 92);
            this.comboBoxYakit.Name = "comboBoxYakit";
            this.comboBoxYakit.Size = new System.Drawing.Size(201, 31);
            this.comboBoxYakit.TabIndex = 25;
            this.comboBoxYakit.SelectedIndexChanged += new System.EventHandler(this.comboBoxYakit_SelectedIndexChanged);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Items.AddRange(new object[] {
            "Tesla",
            "Chevrolet",
            "Maserati",
            "Aston Martin",
            "Mercedes",
            "Audi",
            "BMW",
            "Volvo",
            "Mazda",
            "Alfa Romeo",
            "Ford",
            "Jeep"});
            this.comboBoxMarka.Location = new System.Drawing.Point(117, 97);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(201, 31);
            this.comboBoxMarka.TabIndex = 24;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // textBoxKiralamaUcret
            // 
            this.textBoxKiralamaUcret.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKiralamaUcret.Location = new System.Drawing.Point(509, 156);
            this.textBoxKiralamaUcret.Name = "textBoxKiralamaUcret";
            this.textBoxKiralamaUcret.Size = new System.Drawing.Size(201, 30);
            this.textBoxKiralamaUcret.TabIndex = 23;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKm.Location = new System.Drawing.Point(509, 32);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(201, 30);
            this.textBoxKm.TabIndex = 21;
            this.textBoxKm.TextChanged += new System.EventHandler(this.textBoxKm_TextChanged);
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRenk.Location = new System.Drawing.Point(115, 224);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.Size = new System.Drawing.Size(201, 30);
            this.textBoxRenk.TabIndex = 20;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlaka.Location = new System.Drawing.Point(117, 29);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(201, 30);
            this.textBoxPlaka.TabIndex = 22;
            // 
            // buttonKayit
            // 
            this.buttonKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKayit.ImageIndex = 0;
            this.buttonKayit.ImageList = this.ımageList1;
            this.buttonKayit.Location = new System.Drawing.Point(337, 231);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(126, 49);
            this.buttonKayit.TabIndex = 19;
            this.buttonKayit.Text = "Güncelle";
            this.buttonKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(729, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(751, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 38;
            this.button1.Text = "Resim Değiştir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonResim);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelKm);
            this.Controls.Add(this.labelYakit);
            this.Controls.Add(this.labelRenk);
            this.Controls.Add(this.labelKiralamaUc);
            this.Controls.Add(this.labelMara);
            this.Controls.Add(this.labelPlaka);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxYakit);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.textBoxKiralamaUcret);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxRenk);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Listeleme sayfası";
            this.Load += new System.EventHandler(this.AracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonResim;
        private Button buttonIptal;
        private Label labelModel;
        private Label labelKm;
        private Label labelYakit;
        private Label labelRenk;
        private Label labelKiralamaUc;
        private Label labelMara;
        private Label labelPlaka;
        private ComboBox comboBoxModel;
        private ComboBox comboBoxYakit;
        private ComboBox comboBoxMarka;
        private TextBox textBoxKiralamaUcret;
        private TextBox textBoxKm;
        private TextBox textBoxRenk;
        private TextBox textBoxPlaka;
        private Button buttonKayit;
        private PictureBox pictureBox2;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private ImageList ımageList1;
    }
}