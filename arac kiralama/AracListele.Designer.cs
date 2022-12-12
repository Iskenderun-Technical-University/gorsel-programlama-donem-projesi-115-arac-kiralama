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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonResim = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonResim
            // 
            this.buttonResim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResim.Location = new System.Drawing.Point(534, 174);
            this.buttonResim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(38, 26);
            this.buttonResim.TabIndex = 37;
            this.buttonResim.Text = "Sil";
            this.buttonResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIptal.ImageIndex = 5;
            this.buttonIptal.Location = new System.Drawing.Point(434, 174);
            this.buttonIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(81, 26);
            this.buttonIptal.TabIndex = 36;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(27, 120);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(61, 20);
            this.labelModel.TabIndex = 33;
            this.labelModel.Text = "Model :";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKm.Location = new System.Drawing.Point(5, 172);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(83, 20);
            this.labelKm.TabIndex = 32;
            this.labelKm.Text = "Kilometre :";
            // 
            // labelYakit
            // 
            this.labelYakit.AutoSize = true;
            this.labelYakit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYakit.Location = new System.Drawing.Point(374, 76);
            this.labelYakit.Name = "labelYakit";
            this.labelYakit.Size = new System.Drawing.Size(50, 20);
            this.labelYakit.TabIndex = 31;
            this.labelYakit.Text = "Yakit :";
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRenk.Location = new System.Drawing.Point(373, 25);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(51, 20);
            this.labelRenk.TabIndex = 30;
            this.labelRenk.Text = "Renk :";
            // 
            // labelKiralamaUc
            // 
            this.labelKiralamaUc.AutoSize = true;
            this.labelKiralamaUc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKiralamaUc.Location = new System.Drawing.Point(306, 123);
            this.labelKiralamaUc.Name = "labelKiralamaUc";
            this.labelKiralamaUc.Size = new System.Drawing.Size(118, 20);
            this.labelKiralamaUc.TabIndex = 29;
            this.labelKiralamaUc.Text = "Kıralama Ücret :";
            // 
            // labelMara
            // 
            this.labelMara.AutoSize = true;
            this.labelMara.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMara.Location = new System.Drawing.Point(27, 76);
            this.labelMara.Name = "labelMara";
            this.labelMara.Size = new System.Drawing.Size(61, 20);
            this.labelMara.TabIndex = 28;
            this.labelMara.Text = "Marka :";
            // 
            // labelPlaka
            // 
            this.labelPlaka.AutoSize = true;
            this.labelPlaka.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlaka.Location = new System.Drawing.Point(34, 25);
            this.labelPlaka.Name = "labelPlaka";
            this.labelPlaka.Size = new System.Drawing.Size(54, 20);
            this.labelPlaka.TabIndex = 27;
            this.labelPlaka.Text = "Plaka :";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(102, 117);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(176, 27);
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
            this.comboBoxYakit.Location = new System.Drawing.Point(445, 69);
            this.comboBoxYakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxYakit.Name = "comboBoxYakit";
            this.comboBoxYakit.Size = new System.Drawing.Size(176, 27);
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
            this.comboBoxMarka.Location = new System.Drawing.Point(102, 73);
            this.comboBoxMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(176, 27);
            this.comboBoxMarka.TabIndex = 24;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // textBoxKiralamaUcret
            // 
            this.textBoxKiralamaUcret.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKiralamaUcret.Location = new System.Drawing.Point(445, 117);
            this.textBoxKiralamaUcret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKiralamaUcret.Name = "textBoxKiralamaUcret";
            this.textBoxKiralamaUcret.Size = new System.Drawing.Size(176, 26);
            this.textBoxKiralamaUcret.TabIndex = 23;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKm.Location = new System.Drawing.Point(102, 174);
            this.textBoxKm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(176, 26);
            this.textBoxKm.TabIndex = 21;
            this.textBoxKm.TextChanged += new System.EventHandler(this.textBoxKm_TextChanged);
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRenk.Location = new System.Drawing.Point(445, 25);
            this.textBoxRenk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.Size = new System.Drawing.Size(176, 26);
            this.textBoxRenk.TabIndex = 20;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlaka.Location = new System.Drawing.Point(102, 22);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(176, 26);
            this.textBoxPlaka.TabIndex = 22;
            // 
            // buttonKayit
            // 
            this.buttonKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKayit.ImageIndex = 4;
            this.buttonKayit.Location = new System.Drawing.Point(339, 174);
            this.buttonKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(87, 26);
            this.buttonKayit.TabIndex = 19;
            this.buttonKayit.Text = "Güncelle";
            this.buttonKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(638, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(660, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 38;
            this.button1.Text = "Resim Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}