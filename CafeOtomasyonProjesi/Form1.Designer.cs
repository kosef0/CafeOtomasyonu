namespace CafeOtomasyonProjesi
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.girisbuton = new System.Windows.Forms.Button();
            this.kuladılabel = new System.Windows.Forms.Label();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 227);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeOtomasyonProjesi.Properties.Resources.icons8_user_100;
            this.pictureBox2.Location = new System.Drawing.Point(209, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox1.Location = new System.Drawing.Point(183, 262);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 32);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox2.Location = new System.Drawing.Point(183, 326);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(276, 32);
            this.textBox2.TabIndex = 4;
            // 
            // girisbuton
            // 
            this.girisbuton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.girisbuton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.girisbuton.Font = new System.Drawing.Font("Verdana", 12F);
            this.girisbuton.ImageKey = "(none)";
            this.girisbuton.Location = new System.Drawing.Point(103, 398);
            this.girisbuton.Margin = new System.Windows.Forms.Padding(5);
            this.girisbuton.Name = "girisbuton";
            this.girisbuton.Size = new System.Drawing.Size(266, 47);
            this.girisbuton.TabIndex = 6;
            this.girisbuton.Text = "Giriş";
            this.girisbuton.UseVisualStyleBackColor = false;
            this.girisbuton.Click += new System.EventHandler(this.girisbuton_Click);
            // 
            // kuladılabel
            // 
            this.kuladılabel.AutoSize = true;
            this.kuladılabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.kuladılabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.kuladılabel.Location = new System.Drawing.Point(33, 265);
            this.kuladılabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.kuladılabel.Name = "kuladılabel";
            this.kuladılabel.Size = new System.Drawing.Size(137, 25);
            this.kuladılabel.TabIndex = 13;
            this.kuladılabel.Text = "Kullanıcı Adı";
            // 
            // sifrelabel
            // 
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sifrelabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.sifrelabel.Location = new System.Drawing.Point(110, 326);
            this.sifrelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(60, 25);
            this.sifrelabel.TabIndex = 14;
            this.sifrelabel.Text = "Şifre";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkCyan;
            this.exit.BackgroundImage = global::CafeOtomasyonProjesi.Properties.Resources.icons8_exit_96;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 19.8F, System.Drawing.FontStyle.Bold);
            this.exit.Location = new System.Drawing.Point(389, 398);
            this.exit.Margin = new System.Windows.Forms.Padding(5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(53, 53);
            this.exit.TabIndex = 12;
            this.exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.girisbuton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(502, 512);
            this.Controls.Add(this.sifrelabel);
            this.Controls.Add(this.kuladılabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.girisbuton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button girisbuton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label kuladılabel;
        private System.Windows.Forms.Label sifrelabel;
    }
}

