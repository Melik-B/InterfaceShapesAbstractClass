
namespace InterfaceShapesAbstractClass
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
            this.btDaire = new System.Windows.Forms.Button();
            this.btDortgen = new System.Windows.Forms.Button();
            this.btDikUcgen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbYaricap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbYaricap = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btHesapla = new System.Windows.Forms.Button();
            this.ddlIslem = new System.Windows.Forms.ComboBox();
            this.tbGenislik = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbGenislik = new System.Windows.Forms.Label();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbYukseklik = new System.Windows.Forms.Label();
            this.pbDiger = new System.Windows.Forms.Panel();
            this.pDaire = new System.Windows.Forms.Panel();
            this.cbPI3 = new System.Windows.Forms.CheckBox();
            this.lbHata = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.pbKare = new System.Windows.Forms.PictureBox();
            this.pbUcgen = new System.Windows.Forms.PictureBox();
            this.pbDaire = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pbDiger.SuspendLayout();
            this.pDaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUcgen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDaire)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btDaire);
            this.panel1.Controls.Add(this.btDortgen);
            this.panel1.Controls.Add(this.btDikUcgen);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 549);
            this.panel1.TabIndex = 0;
            // 
            // btDaire
            // 
            this.btDaire.FlatAppearance.BorderSize = 0;
            this.btDaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDaire.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btDaire.Location = new System.Drawing.Point(0, 280);
            this.btDaire.Name = "btDaire";
            this.btDaire.Size = new System.Drawing.Size(182, 36);
            this.btDaire.TabIndex = 1;
            this.btDaire.Text = "Daire";
            this.btDaire.UseVisualStyleBackColor = true;
            this.btDaire.Click += new System.EventHandler(this.btDaire_Click);
            // 
            // btDortgen
            // 
            this.btDortgen.FlatAppearance.BorderSize = 0;
            this.btDortgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDortgen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDortgen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btDortgen.Location = new System.Drawing.Point(0, 230);
            this.btDortgen.Name = "btDortgen";
            this.btDortgen.Size = new System.Drawing.Size(182, 36);
            this.btDortgen.TabIndex = 1;
            this.btDortgen.Text = "Dörtgen";
            this.btDortgen.UseVisualStyleBackColor = true;
            this.btDortgen.Click += new System.EventHandler(this.btDortgen_Click);
            // 
            // btDikUcgen
            // 
            this.btDikUcgen.FlatAppearance.BorderSize = 0;
            this.btDikUcgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDikUcgen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDikUcgen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btDikUcgen.Location = new System.Drawing.Point(0, 180);
            this.btDikUcgen.Name = "btDikUcgen";
            this.btDikUcgen.Size = new System.Drawing.Size(182, 36);
            this.btDikUcgen.TabIndex = 1;
            this.btDikUcgen.Text = "Dik üçgen";
            this.btDikUcgen.UseVisualStyleBackColor = true;
            this.btDikUcgen.Click += new System.EventHandler(this.btDikUcgen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfaceShapesAbstractClass.Properties.Resources.ucgen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "         ALAN VE\r\nÇEVRE  HESAPLAMA";
            // 
            // lbYaricap
            // 
            this.lbYaricap.AutoSize = true;
            this.lbYaricap.Enabled = false;
            this.lbYaricap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbYaricap.ForeColor = System.Drawing.Color.Silver;
            this.lbYaricap.Location = new System.Drawing.Point(7, 15);
            this.lbYaricap.Name = "lbYaricap";
            this.lbYaricap.Size = new System.Drawing.Size(87, 26);
            this.lbYaricap.TabIndex = 12;
            this.lbYaricap.Text = "Yarıçap";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 2);
            this.panel2.TabIndex = 11;
            // 
            // tbYaricap
            // 
            this.tbYaricap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tbYaricap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYaricap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbYaricap.ForeColor = System.Drawing.Color.White;
            this.tbYaricap.Location = new System.Drawing.Point(12, 17);
            this.tbYaricap.Name = "tbYaricap";
            this.tbYaricap.Size = new System.Drawing.Size(330, 25);
            this.tbYaricap.TabIndex = 10;
            this.tbYaricap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbYaricap_MouseClick);
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Gray;
            this.btClose.Location = new System.Drawing.Point(1319, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(55, 46);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btHesapla
            // 
            this.btHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHesapla.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btHesapla.Location = new System.Drawing.Point(692, 390);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(182, 36);
            this.btHesapla.TabIndex = 1;
            this.btHesapla.Text = "HESAPLA";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // ddlIslem
            // 
            this.ddlIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlIslem.FormattingEnabled = true;
            this.ddlIslem.Location = new System.Drawing.Point(617, 355);
            this.ddlIslem.Name = "ddlIslem";
            this.ddlIslem.Size = new System.Drawing.Size(330, 23);
            this.ddlIslem.TabIndex = 13;
            // 
            // tbGenislik
            // 
            this.tbGenislik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tbGenislik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGenislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbGenislik.ForeColor = System.Drawing.Color.White;
            this.tbGenislik.Location = new System.Drawing.Point(15, 16);
            this.tbGenislik.Name = "tbGenislik";
            this.tbGenislik.Size = new System.Drawing.Size(330, 25);
            this.tbGenislik.TabIndex = 10;
            this.tbGenislik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbGenislik_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(15, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 2);
            this.panel3.TabIndex = 11;
            // 
            // lbGenislik
            // 
            this.lbGenislik.AutoSize = true;
            this.lbGenislik.Enabled = false;
            this.lbGenislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbGenislik.ForeColor = System.Drawing.Color.Silver;
            this.lbGenislik.Location = new System.Drawing.Point(10, 14);
            this.lbGenislik.Name = "lbGenislik";
            this.lbGenislik.Size = new System.Drawing.Size(90, 26);
            this.lbGenislik.TabIndex = 12;
            this.lbGenislik.Text = "Genişlik";
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tbYukseklik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbYukseklik.ForeColor = System.Drawing.Color.White;
            this.tbYukseklik.Location = new System.Drawing.Point(15, 69);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(330, 25);
            this.tbYukseklik.TabIndex = 10;
            this.tbYukseklik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbYukseklik_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Location = new System.Drawing.Point(15, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 2);
            this.panel4.TabIndex = 11;
            // 
            // lbYukseklik
            // 
            this.lbYukseklik.AutoSize = true;
            this.lbYukseklik.Enabled = false;
            this.lbYukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbYukseklik.ForeColor = System.Drawing.Color.Silver;
            this.lbYukseklik.Location = new System.Drawing.Point(10, 67);
            this.lbYukseklik.Name = "lbYukseklik";
            this.lbYukseklik.Size = new System.Drawing.Size(106, 26);
            this.lbYukseklik.TabIndex = 12;
            this.lbYukseklik.Text = "Yükseklik";
            // 
            // pbDiger
            // 
            this.pbDiger.BackColor = System.Drawing.Color.Transparent;
            this.pbDiger.Controls.Add(this.lbGenislik);
            this.pbDiger.Controls.Add(this.tbGenislik);
            this.pbDiger.Controls.Add(this.lbYukseklik);
            this.pbDiger.Controls.Add(this.tbYukseklik);
            this.pbDiger.Controls.Add(this.panel3);
            this.pbDiger.Controls.Add(this.panel4);
            this.pbDiger.Location = new System.Drawing.Point(223, 413);
            this.pbDiger.Name = "pbDiger";
            this.pbDiger.Size = new System.Drawing.Size(371, 113);
            this.pbDiger.TabIndex = 14;
            this.pbDiger.Visible = false;
            // 
            // pDaire
            // 
            this.pDaire.BackColor = System.Drawing.Color.Transparent;
            this.pDaire.Controls.Add(this.cbPI3);
            this.pDaire.Controls.Add(this.lbYaricap);
            this.pDaire.Controls.Add(this.tbYaricap);
            this.pDaire.Controls.Add(this.panel2);
            this.pDaire.Location = new System.Drawing.Point(605, 258);
            this.pDaire.Name = "pDaire";
            this.pDaire.Size = new System.Drawing.Size(364, 89);
            this.pDaire.TabIndex = 15;
            // 
            // cbPI3
            // 
            this.cbPI3.AutoSize = true;
            this.cbPI3.BackColor = System.Drawing.Color.Transparent;
            this.cbPI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPI3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cbPI3.Location = new System.Drawing.Point(144, 52);
            this.cbPI3.Name = "cbPI3";
            this.cbPI3.Size = new System.Drawing.Size(66, 29);
            this.cbPI3.TabIndex = 18;
            this.cbPI3.Text = "pi 3";
            this.cbPI3.UseVisualStyleBackColor = false;
            // 
            // lbHata
            // 
            this.lbHata.AutoSize = true;
            this.lbHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbHata.ForeColor = System.Drawing.Color.Red;
            this.lbHata.Location = new System.Drawing.Point(219, 380);
            this.lbHata.Name = "lbHata";
            this.lbHata.Size = new System.Drawing.Size(60, 24);
            this.lbHata.TabIndex = 16;
            this.lbHata.Text = "label4";
            this.lbHata.Visible = false;
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbSonuc.Location = new System.Drawing.Point(362, 335);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(70, 24);
            this.lbSonuc.TabIndex = 17;
            this.lbSonuc.Text = "Sonuç:";
            this.lbSonuc.Visible = false;
            // 
            // pbKare
            // 
            this.pbKare.Image = global::InterfaceShapesAbstractClass.Properties.Resources.Kare;
            this.pbKare.Location = new System.Drawing.Point(985, 12);
            this.pbKare.Name = "pbKare";
            this.pbKare.Size = new System.Drawing.Size(364, 240);
            this.pbKare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKare.TabIndex = 18;
            this.pbKare.TabStop = false;
            this.pbKare.Visible = false;
            // 
            // pbUcgen
            // 
            this.pbUcgen.Image = global::InterfaceShapesAbstractClass.Properties.Resources.ucgen;
            this.pbUcgen.Location = new System.Drawing.Point(223, 12);
            this.pbUcgen.Name = "pbUcgen";
            this.pbUcgen.Size = new System.Drawing.Size(364, 240);
            this.pbUcgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUcgen.TabIndex = 18;
            this.pbUcgen.TabStop = false;
            this.pbUcgen.Visible = false;
            // 
            // pbDaire
            // 
            this.pbDaire.Image = global::InterfaceShapesAbstractClass.Properties.Resources.Daire;
            this.pbDaire.Location = new System.Drawing.Point(605, 12);
            this.pbDaire.Name = "pbDaire";
            this.pbDaire.Size = new System.Drawing.Size(364, 240);
            this.pbDaire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDaire.TabIndex = 18;
            this.pbDaire.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1374, 549);
            this.Controls.Add(this.pbKare);
            this.Controls.Add(this.pbUcgen);
            this.Controls.Add(this.pbDaire);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lbHata);
            this.Controls.Add(this.pDaire);
            this.Controls.Add(this.pbDiger);
            this.Controls.Add(this.ddlIslem);
            this.Controls.Add(this.btHesapla);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pbDiger.ResumeLayout(false);
            this.pbDiger.PerformLayout();
            this.pDaire.ResumeLayout(false);
            this.pDaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUcgen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDikUcgen;
        private System.Windows.Forms.Button btDortgen;
        private System.Windows.Forms.Button btDaire;
        private System.Windows.Forms.Label lbYaricap;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox tbYaricap;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btHesapla;
        private System.Windows.Forms.ComboBox ddlIslem;
        public System.Windows.Forms.TextBox tbGenislik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbGenislik;
        public System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbYukseklik;
        private System.Windows.Forms.Panel pbDiger;
        private System.Windows.Forms.Panel pDaire;
        private System.Windows.Forms.Label lbHata;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.CheckBox cbPI3;
        private System.Windows.Forms.PictureBox pbDaire;
        private System.Windows.Forms.PictureBox pbUcgen;
        private System.Windows.Forms.PictureBox pbKare;
    }
}

