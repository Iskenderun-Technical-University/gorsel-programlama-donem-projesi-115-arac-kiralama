namespace arac_kiralama
{
    partial class frmMusterEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusterEkle));
            this.labelKm = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDogum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelKm.Location = new System.Drawing.Point(26, 26);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(116, 21);
            this.labelKm.TabIndex = 0;
            this.labelKm.Text = "Kimlik Bilgiler";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEkle.ImageIndex = 1;
            this.buttonEkle.ImageList = this.ımageList1;
            this.buttonEkle.Location = new System.Drawing.Point(71, 396);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(100, 47);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "reject.png");
            this.ımageList1.Images.SetKeyName(1, "add-user.png");
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(149, 67);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(217, 23);
            this.textBoxAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adi :";
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmail.Location = new System.Drawing.Point(26, 345);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(70, 20);
            this.labelmail.TabIndex = 5;
            this.labelmail.Text = "e-posta :";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(149, 346);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(217, 23);
            this.textBoxMail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = " TC No :";
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(149, 164);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(217, 23);
            this.textBoxTc.TabIndex = 6;
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSoyad.Location = new System.Drawing.Point(12, 99);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(59, 20);
            this.labelSoyad.TabIndex = 9;
            this.labelSoyad.Text = "Soyad :";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(149, 100);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(217, 23);
            this.textBoxSoyad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doğum Tarih :";
            // 
            // textBoxDogum
            // 
            this.textBoxDogum.Location = new System.Drawing.Point(149, 133);
            this.textBoxDogum.Name = "textBoxDogum";
            this.textBoxDogum.Size = new System.Drawing.Size(217, 23);
            this.textBoxDogum.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adres :";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(149, 257);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(217, 23);
            this.textBoxAdres.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tel : ";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(149, 296);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(217, 23);
            this.textBoxTel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kimlik Bilgiler";
            // 
            // buttonIptal
            // 
            this.buttonIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIptal.ImageIndex = 0;
            this.buttonIptal.ImageList = this.ımageList1;
            this.buttonIptal.Location = new System.Drawing.Point(227, 396);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(100, 47);
            this.buttonIptal.TabIndex = 17;
            this.buttonIptal.Text = "Iptal";
            this.buttonIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // frmMusterEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(386, 455);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDogum);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.labelKm);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMusterEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusterEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelKm;
        private Button buttonEkle;
        private ImageList ımageList1;
        private TextBox textBoxAd;
        private Label label1;
        private Label labelmail;
        private TextBox textBoxMail;
        private Label label3;
        private TextBox textBoxTc;
        private Label labelSoyad;
        private TextBox textBoxSoyad;
        private Label label5;
        private TextBox textBoxDogum;
        private Label label4;
        private TextBox textBoxAdres;
        private Label label6;
        private TextBox textBoxTel;
        private Label label7;
        private Button buttonIptal;
    }
}