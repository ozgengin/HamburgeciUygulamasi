namespace OOP_Hamburgeci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.lbxSirapisler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSirapisiTamamla = new System.Windows.Forms.Button();
            this.cbMenuSec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBuyuk);
            this.groupBox1.Controls.Add(this.rdoOrta);
            this.groupBox1.Controls.Add(this.rdoKucuk);
            this.groupBox1.Location = new System.Drawing.Point(31, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOYUT SEÇİN";
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(146, 30);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(60, 19);
            this.rdoBuyuk.TabIndex = 6;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(81, 30);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(50, 19);
            this.rdoOrta.TabIndex = 5;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(0, 30);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(63, 19);
            this.rdoKucuk.TabIndex = 4;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük ";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.AutoScroll = true;
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(31, 357);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(252, 171);
            this.flpEkstraMalzemeler.TabIndex = 4;
            // 
            // lbxSirapisler
            // 
            this.lbxSirapisler.FormattingEnabled = true;
            this.lbxSirapisler.HorizontalScrollbar = true;
            this.lbxSirapisler.ItemHeight = 15;
            this.lbxSirapisler.Location = new System.Drawing.Point(315, 30);
            this.lbxSirapisler.Name = "lbxSirapisler";
            this.lbxSirapisler.Size = new System.Drawing.Size(700, 499);
            this.lbxSirapisler.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ADET:";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(31, 575);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(52, 23);
            this.nmrAdet.TabIndex = 7;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(147, 544);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(136, 54);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToplamTutar.Location = new System.Drawing.Point(440, 564);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(14, 15);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "0";
            // 
            // btnSirapisiTamamla
            // 
            this.btnSirapisiTamamla.Location = new System.Drawing.Point(796, 544);
            this.btnSirapisiTamamla.Name = "btnSirapisiTamamla";
            this.btnSirapisiTamamla.Size = new System.Drawing.Size(219, 55);
            this.btnSirapisiTamamla.TabIndex = 11;
            this.btnSirapisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSirapisiTamamla.UseVisualStyleBackColor = true;
            this.btnSirapisiTamamla.Click += new System.EventHandler(this.btnSirapisiTamamla_Click);
            // 
            // cbMenuSec
            // 
            this.cbMenuSec.FormattingEnabled = true;
            this.cbMenuSec.Location = new System.Drawing.Point(31, 234);
            this.cbMenuSec.Name = "cbMenuSec";
            this.cbMenuSec.Size = new System.Drawing.Size(252, 23);
            this.cbMenuSec.TabIndex = 12;
            this.cbMenuSec.SelectedIndexChanged += new System.EventHandler(this.cbMenuSec_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "MALZEME SEÇİN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 623);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMenuSec);
            this.Controls.Add(this.btnSirapisiTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxSirapisler);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdoBuyuk;
        private RadioButton rdoOrta;
        private RadioButton rdoKucuk;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private ListBox lbxSirapisler;
        private Label label2;
        private NumericUpDown nmrAdet;
        private Button btnSiparisEkle;
        private Label label3;
        private Label lblToplamTutar;
        private Button btnSirapisiTamamla;
        private ComboBox cbMenuSec;
        private Label label4;
    }
}