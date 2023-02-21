namespace OOP_Hamburgeci
{
    partial class MyMDIForm
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
            this.msHamburgerMenu = new System.Windows.Forms.MenuStrip();
            this.msSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.msSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.msSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.msUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msEkstraMalEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msHamburgerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHamburgerMenu
            // 
            this.msHamburgerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSiparisYonetimi,
            this.msUrunYonetimi});
            this.msHamburgerMenu.Location = new System.Drawing.Point(0, 0);
            this.msHamburgerMenu.Name = "msHamburgerMenu";
            this.msHamburgerMenu.Size = new System.Drawing.Size(800, 24);
            this.msHamburgerMenu.TabIndex = 0;
            this.msHamburgerMenu.Text = "menuStrip1";
            // 
            // msSiparisYonetimi
            // 
            this.msSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSiparisOlustur,
            this.msSiparisBilgileri});
            this.msSiparisYonetimi.Name = "msSiparisYonetimi";
            this.msSiparisYonetimi.Size = new System.Drawing.Size(103, 20);
            this.msSiparisYonetimi.Text = "Sipariş Yönetimi";
            // 
            // msSiparisOlustur
            // 
            this.msSiparisOlustur.Name = "msSiparisOlustur";
            this.msSiparisOlustur.Size = new System.Drawing.Size(150, 22);
            this.msSiparisOlustur.Text = "Sipariş Oluştur";
            this.msSiparisOlustur.Click += new System.EventHandler(this.msSiparisOlustur_Click);
            // 
            // msSiparisBilgileri
            // 
            this.msSiparisBilgileri.Name = "msSiparisBilgileri";
            this.msSiparisBilgileri.Size = new System.Drawing.Size(150, 22);
            this.msSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.msSiparisBilgileri.Click += new System.EventHandler(this.msSiparisBilgileri_Click);
            // 
            // msUrunYonetimi
            // 
            this.msUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuEkle,
            this.msEkstraMalEkle});
            this.msUrunYonetimi.Name = "msUrunYonetimi";
            this.msUrunYonetimi.Size = new System.Drawing.Size(95, 20);
            this.msUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // msMenuEkle
            // 
            this.msMenuEkle.Name = "msMenuEkle";
            this.msMenuEkle.Size = new System.Drawing.Size(180, 22);
            this.msMenuEkle.Text = "Menü Ekle";
            this.msMenuEkle.Click += new System.EventHandler(this.msMenuEkle_Click);
            // 
            // msEkstraMalEkle
            // 
            this.msEkstraMalEkle.Name = "msEkstraMalEkle";
            this.msEkstraMalEkle.Size = new System.Drawing.Size(180, 22);
            this.msEkstraMalEkle.Text = "Ekstra Malzeme Ekle";
            this.msEkstraMalEkle.Click += new System.EventHandler(this.msEkstraMalEkle_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msHamburgerMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msHamburgerMenu;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.Load += new System.EventHandler(this.MyMDIForm_Load);
            this.msHamburgerMenu.ResumeLayout(false);
            this.msHamburgerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msHamburgerMenu;
        private ToolStripMenuItem msSiparisYonetimi;
        private ToolStripMenuItem msSiparisOlustur;
        private ToolStripMenuItem msSiparisBilgileri;
        private ToolStripMenuItem msUrunYonetimi;
        private ToolStripMenuItem msMenuEkle;
        private ToolStripMenuItem msEkstraMalEkle;
    }
}