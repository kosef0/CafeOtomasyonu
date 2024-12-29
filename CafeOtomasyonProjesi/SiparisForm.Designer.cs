namespace CafeOtomasyonProjesi
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.grpUrun = new System.Windows.Forms.GroupBox();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpSepet = new System.Windows.Forms.GroupBox();
            this.lstSepet = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerilenMiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboOdemeTuru = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHesapOde = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.grpUrun.SuspendLayout();
            this.grpSepet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUrun
            // 
            this.grpUrun.Controls.Add(this.lstUrunler);
            this.grpUrun.Location = new System.Drawing.Point(12, 12);
            this.grpUrun.Name = "grpUrun";
            this.grpUrun.Size = new System.Drawing.Size(325, 619);
            this.grpUrun.TabIndex = 7;
            this.grpUrun.TabStop = false;
            this.grpUrun.Text = "Menü";
            // 
            // lstUrunler
            // 
            this.lstUrunler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstUrunler.HideSelection = false;
            this.lstUrunler.LargeImageList = this.ımageList1;
            this.lstUrunler.Location = new System.Drawing.Point(0, 32);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrunler.MultiSelect = false;
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(318, 580);
            this.lstUrunler.TabIndex = 1;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.View = System.Windows.Forms.View.SmallIcon;
            this.lstUrunler.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstUrunler_ItemSelectionChanged);
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // grpSepet
            // 
            this.grpSepet.Controls.Add(this.lstSepet);
            this.grpSepet.Location = new System.Drawing.Point(353, 12);
            this.grpSepet.Name = "grpSepet";
            this.grpSepet.Size = new System.Drawing.Size(324, 272);
            this.grpSepet.TabIndex = 6;
            this.grpSepet.TabStop = false;
            this.grpSepet.Text = "Sipariş";
            // 
            // lstSepet
            // 
            this.lstSepet.BackColor = System.Drawing.Color.LightBlue;
            this.lstSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSepet.HideSelection = false;
            this.lstSepet.LargeImageList = this.ımageList1;
            this.lstSepet.Location = new System.Drawing.Point(3, 28);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(318, 241);
            this.lstSepet.TabIndex = 4;
            this.lstSepet.UseCompatibleStateImageBehavior = false;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            this.lstSepet.DoubleClick += new System.EventHandler(this.lstSepet_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtParaUstu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVerilenMiktar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtToplam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboOdemeTuru);
            this.groupBox1.Location = new System.Drawing.Point(719, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(301, 414);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.label12.Location = new System.Drawing.Point(151, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(230, 238);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "₺";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(229, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "₺";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(143, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 26);
            this.textBox2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.label9.Location = new System.Drawing.Point(48, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Alınacak ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(177, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.label6.Location = new System.Drawing.Point(42, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Para Üstü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.label8.Location = new System.Drawing.Point(24, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "İndirim Ekle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(229, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "₺";
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.BackColor = System.Drawing.Color.YellowGreen;
            this.txtParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaUstu.ForeColor = System.Drawing.Color.White;
            this.txtParaUstu.Location = new System.Drawing.Point(143, 154);
            this.txtParaUstu.Margin = new System.Windows.Forms.Padding(4);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(79, 26);
            this.txtParaUstu.TabIndex = 14;
            this.txtParaUstu.Text = "0";
            this.txtParaUstu.TextChanged += new System.EventHandler(this.txtParaUstu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "İndirimli Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(229, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "₺";
            // 
            // txtVerilenMiktar
            // 
            this.txtVerilenMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVerilenMiktar.Location = new System.Drawing.Point(143, 223);
            this.txtVerilenMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerilenMiktar.Name = "txtVerilenMiktar";
            this.txtVerilenMiktar.Size = new System.Drawing.Size(79, 45);
            this.txtVerilenMiktar.TabIndex = 11;
            this.txtVerilenMiktar.Text = "0";
            this.txtVerilenMiktar.TextChanged += new System.EventHandler(this.txtVerilenMiktar_TextChanged);
            this.txtVerilenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerilenMiktar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(229, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "₺";
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.White;
            this.txtToplam.Enabled = false;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(143, 39);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(4);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(79, 26);
            this.txtToplam.TabIndex = 9;
            this.txtToplam.Text = "0,0";
            this.txtToplam.TextChanged += new System.EventHandler(this.txtToplam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ödeme Türü:";
            // 
            // comboOdemeTuru
            // 
            this.comboOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeTuru.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOdemeTuru.FormattingEnabled = true;
            this.comboOdemeTuru.Location = new System.Drawing.Point(142, 275);
            this.comboOdemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.comboOdemeTuru.Name = "comboOdemeTuru";
            this.comboOdemeTuru.Size = new System.Drawing.Size(151, 27);
            this.comboOdemeTuru.TabIndex = 9;
            this.comboOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.comboOdemeTuru_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeOtomasyonProjesi.Properties.Resources._1_ezzUcV8SiJxOFH4Um8AHDA;
            this.pictureBox2.Location = new System.Drawing.Point(356, 484);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(342, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeOtomasyonProjesi.Properties.Resources.icons8_cashier_64;
            this.pictureBox1.Location = new System.Drawing.Point(784, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnHesapOde
            // 
            this.btnHesapOde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapOde.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.btnHesapOde.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapOde.Image")));
            this.btnHesapOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapOde.Location = new System.Drawing.Point(772, 534);
            this.btnHesapOde.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapOde.Name = "btnHesapOde";
            this.btnHesapOde.Size = new System.Drawing.Size(195, 55);
            this.btnHesapOde.TabIndex = 8;
            this.btnHesapOde.Text = " Öde";
            this.btnHesapOde.UseVisualStyleBackColor = true;
            this.btnHesapOde.Click += new System.EventHandler(this.btnHesapOde_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
            this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSil.Location = new System.Drawing.Point(403, 372);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(238, 71);
            this.btnUrunSil.TabIndex = 12;
            this.btnUrunSil.Text = "          Sipariş Çıkar";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.lstSepet_DoubleClick);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUrunEkle.Location = new System.Drawing.Point(403, 291);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(238, 73);
            this.btnUrunEkle.TabIndex = 13;
            this.btnUrunEkle.Text = "        Sipariş Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.grpSepet);
            this.Controls.Add(this.grpUrun);
            this.Controls.Add(this.btnHesapOde);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMasa_FormClosing);
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            this.grpUrun.ResumeLayout(false);
            this.grpSepet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrun;
        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.GroupBox grpSepet;
        private System.Windows.Forms.ListView lstSepet;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVerilenMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Button btnHesapOde;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboOdemeTuru;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}