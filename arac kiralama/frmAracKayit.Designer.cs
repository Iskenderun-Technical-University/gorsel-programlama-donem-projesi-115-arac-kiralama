namespace arac_kiralama
{
    partial class frmAracKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKayit));
            this.buttonKayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxRenk = new System.Windows.Forms.TextBox();
            this.textBoxKiralamaUcret = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxYakit = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelPlaka = new System.Windows.Forms.Label();
            this.labelMara = new System.Windows.Forms.Label();
            this.labelKiralamaUc = new System.Windows.Forms.Label();
            this.labelRenk = new System.Windows.Forms.Label();
            this.labelYakit = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.buttonResim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKayit
            // 
            this.buttonKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKayit.ImageIndex = 4;
            this.buttonKayit.ImageList = this.ımageList1;
            this.buttonKayit.Location = new System.Drawing.Point(50, 476);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(117, 68);
            this.buttonKayit.TabIndex = 0;
            this.buttonKayit.Text = "Kayıt";
            this.buttonKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete-file.png");
            this.ımageList1.Images.SetKeyName(1, "bin.png");
            this.ımageList1.Images.SetKeyName(2, "changes.png");
            this.ımageList1.Images.SetKeyName(3, "update.png");
            this.ımageList1.Images.SetKeyName(4, "car.png");
            this.ımageList1.Images.SetKeyName(5, "trash.png");
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlaka.Location = new System.Drawing.Point(186, 97);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(197, 30);
            this.textBoxPlaka.TabIndex = 1;
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRenk.Location = new System.Drawing.Point(186, 229);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.Size = new System.Drawing.Size(197, 30);
            this.textBoxRenk.TabIndex = 1;
            // 
            // textBoxKiralamaUcret
            // 
            this.textBoxKiralamaUcret.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKiralamaUcret.Location = new System.Drawing.Point(186, 360);
            this.textBoxKiralamaUcret.Name = "textBoxKiralamaUcret";
            this.textBoxKiralamaUcret.Size = new System.Drawing.Size(197, 30);
            this.textBoxKiralamaUcret.TabIndex = 3;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKm.Location = new System.Drawing.Point(186, 272);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(197, 30);
            this.textBoxKm.TabIndex = 1;
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
            this.comboBoxMarka.Location = new System.Drawing.Point(186, 140);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(197, 31);
            this.comboBoxMarka.TabIndex = 4;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
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
            this.comboBoxYakit.Location = new System.Drawing.Point(186, 317);
            this.comboBoxYakit.Name = "comboBoxYakit";
            this.comboBoxYakit.Size = new System.Drawing.Size(197, 31);
            this.comboBoxYakit.TabIndex = 5;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(186, 184);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(197, 31);
            this.comboBoxModel.TabIndex = 6;
            // 
            // labelPlaka
            // 
            this.labelPlaka.AutoSize = true;
            this.labelPlaka.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlaka.Location = new System.Drawing.Point(32, 101);
            this.labelPlaka.Name = "labelPlaka";
            this.labelPlaka.Size = new System.Drawing.Size(64, 25);
            this.labelPlaka.TabIndex = 7;
            this.labelPlaka.Text = "Plaka :";
            // 
            // labelMara
            // 
            this.labelMara.AutoSize = true;
            this.labelMara.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMara.Location = new System.Drawing.Point(32, 147);
            this.labelMara.Name = "labelMara";
            this.labelMara.Size = new System.Drawing.Size(72, 25);
            this.labelMara.TabIndex = 7;
            this.labelMara.Text = "Marka :";
            // 
            // labelKiralamaUc
            // 
            this.labelKiralamaUc.AutoSize = true;
            this.labelKiralamaUc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKiralamaUc.Location = new System.Drawing.Point(32, 365);
            this.labelKiralamaUc.Name = "labelKiralamaUc";
            this.labelKiralamaUc.Size = new System.Drawing.Size(142, 25);
            this.labelKiralamaUc.TabIndex = 8;
            this.labelKiralamaUc.Text = "Kıralama Ücret :";
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRenk.Location = new System.Drawing.Point(32, 277);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(62, 25);
            this.labelRenk.TabIndex = 10;
            this.labelRenk.Text = "Renk :";
            // 
            // labelYakit
            // 
            this.labelYakit.AutoSize = true;
            this.labelYakit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYakit.Location = new System.Drawing.Point(32, 323);
            this.labelYakit.Name = "labelYakit";
            this.labelYakit.Size = new System.Drawing.Size(59, 25);
            this.labelYakit.TabIndex = 11;
            this.labelYakit.Text = "Yakit :";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKm.Location = new System.Drawing.Point(32, 235);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(103, 25);
            this.labelKm.TabIndex = 13;
            this.labelKm.Text = "Kilometre :";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(32, 189);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(75, 25);
            this.labelModel.TabIndex = 14;
            this.labelModel.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Araç Kayıt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(391, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIptal
            // 
            this.buttonIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIptal.ImageIndex = 5;
            this.buttonIptal.ImageList = this.ımageList1;
            this.buttonIptal.Location = new System.Drawing.Point(221, 476);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(117, 68);
            this.buttonIptal.TabIndex = 17;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // buttonResim
            // 
            this.buttonResim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResim.ImageList = this.ımageList1;
            this.buttonResim.Location = new System.Drawing.Point(423, 343);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(170, 68);
            this.buttonResim.TabIndex = 18;
            this.buttonResim.Text = "Resim Ekle";
            this.buttonResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 620);
            this.Controls.Add(this.buttonResim);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Kayit";
            this.Load += new System.EventHandler(this.frmAracKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonKayit;
        private TextBox textBoxPlaka;
        private TextBox textBoxRenk;
        private TextBox textBoxKiralamaUcret;
        private TextBox textBoxKm;
        private ComboBox comboBoxMarka;
        private ComboBox comboBoxYakit;
        private ComboBox comboBoxModel;
        private Label labelPlaka;
        private Label labelMara;
        private Label labelKiralamaUc;
        private Label labelRenk;
        private Label labelYakit;
        private Label labelKm;
        private Label labelModel;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonIptal;
        private Button buttonResim;
        private ImageList ımageList1;
        private OpenFileDialog openFileDialog1;
    }
}