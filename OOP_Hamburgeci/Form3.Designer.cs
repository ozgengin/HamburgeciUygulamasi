namespace OOP_Hamburgeci
{
    partial class Form3
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
            this.grpMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.nmrMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeEkle
            // 
            this.grpMalzemeEkle.Controls.Add(this.btnMalzemeEkle);
            this.grpMalzemeEkle.Controls.Add(this.nmrMalzemeFiyati);
            this.grpMalzemeEkle.Controls.Add(this.txtMalzemeAdi);
            this.grpMalzemeEkle.Controls.Add(this.label2);
            this.grpMalzemeEkle.Controls.Add(this.label1);
            this.grpMalzemeEkle.Location = new System.Drawing.Point(21, 12);
            this.grpMalzemeEkle.Name = "grpMalzemeEkle";
            this.grpMalzemeEkle.Size = new System.Drawing.Size(347, 215);
            this.grpMalzemeEkle.TabIndex = 1;
            this.grpMalzemeEkle.TabStop = false;
            this.grpMalzemeEkle.Text = "EKSTRA MALZEME EKLEME PANELİ";
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(205, 141);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(123, 55);
            this.btnMalzemeEkle.TabIndex = 4;
            this.btnMalzemeEkle.Text = "EKSTRA MALZEME EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // nmrMalzemeFiyati
            // 
            this.nmrMalzemeFiyati.Location = new System.Drawing.Point(109, 91);
            this.nmrMalzemeFiyati.Name = "nmrMalzemeFiyati";
            this.nmrMalzemeFiyati.Size = new System.Drawing.Size(219, 23);
            this.nmrMalzemeFiyati.TabIndex = 3;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(109, 45);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(219, 23);
            this.txtMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 245);
            this.Controls.Add(this.grpMalzemeEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpMalzemeEkle.ResumeLayout(false);
            this.grpMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMalzemeEkle;
        private Button btnMalzemeEkle;
        private NumericUpDown nmrMalzemeFiyati;
        private TextBox txtMalzemeAdi;
        private Label label2;
        private Label label1;
    }
}