namespace UcakBileti
{
    partial class bilgiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgiler));
            this.ad = new System.Windows.Forms.Label();
            this.soyadı = new System.Windows.Forms.Label();
            this.dogumtarihi = new System.Windows.Forms.Label();
            this.Adtext = new System.Windows.Forms.TextBox();
            this.Soyadtext = new System.Windows.Forms.TextBox();
            this.onayla = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.dogumtarihidt = new System.Windows.Forms.DateTimePicker();
            this.tcnotext = new System.Windows.Forms.Label();
            this.tctext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ad.BackColor = System.Drawing.Color.Transparent;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(61, 98);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(80, 23);
            this.ad.TabIndex = 0;
            this.ad.Text = "Adı:";
            this.ad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soyadı
            // 
            this.soyadı.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soyadı.BackColor = System.Drawing.Color.Transparent;
            this.soyadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadı.Location = new System.Drawing.Point(61, 146);
            this.soyadı.Name = "soyadı";
            this.soyadı.Size = new System.Drawing.Size(80, 23);
            this.soyadı.TabIndex = 4;
            this.soyadı.Text = "Soyadı";
            this.soyadı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dogumtarihi.BackColor = System.Drawing.Color.Transparent;
            this.dogumtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumtarihi.Location = new System.Drawing.Point(42, 194);
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.Size = new System.Drawing.Size(133, 23);
            this.dogumtarihi.TabIndex = 5;
            this.dogumtarihi.Text = "Dogum Tarihi";
            this.dogumtarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adtext
            // 
            this.Adtext.Location = new System.Drawing.Point(181, 98);
            this.Adtext.MaxLength = 50;
            this.Adtext.Name = "Adtext";
            this.Adtext.Size = new System.Drawing.Size(128, 20);
            this.Adtext.TabIndex = 6;
            // 
            // Soyadtext
            // 
            this.Soyadtext.Location = new System.Drawing.Point(181, 146);
            this.Soyadtext.MaxLength = 50;
            this.Soyadtext.Name = "Soyadtext";
            this.Soyadtext.Size = new System.Drawing.Size(128, 20);
            this.Soyadtext.TabIndex = 8;
            // 
            // onayla
            // 
            this.onayla.BackColor = System.Drawing.Color.IndianRed;
            this.onayla.Location = new System.Drawing.Point(299, 339);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(84, 33);
            this.onayla.TabIndex = 17;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = false;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.IndianRed;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.Black;
            this.btnkapat.Location = new System.Drawing.Point(537, 12);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 23);
            this.btnkapat.TabIndex = 33;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // dogumtarihidt
            // 
            this.dogumtarihidt.Location = new System.Drawing.Point(181, 196);
            this.dogumtarihidt.Name = "dogumtarihidt";
            this.dogumtarihidt.Size = new System.Drawing.Size(128, 20);
            this.dogumtarihidt.TabIndex = 34;
            // 
            // tcnotext
            // 
            this.tcnotext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcnotext.BackColor = System.Drawing.Color.Transparent;
            this.tcnotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcnotext.Location = new System.Drawing.Point(30, 239);
            this.tcnotext.Name = "tcnotext";
            this.tcnotext.Size = new System.Drawing.Size(133, 23);
            this.tcnotext.TabIndex = 35;
            this.tcnotext.Text = "T.C No:";
            this.tcnotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tctext
            // 
            this.tctext.Location = new System.Drawing.Point(181, 242);
            this.tctext.MaxLength = 11;
            this.tctext.Name = "tctext";
            this.tctext.Size = new System.Drawing.Size(128, 20);
            this.tctext.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Yolcu Bilgileri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tctext);
            this.Controls.Add(this.tcnotext);
            this.Controls.Add(this.dogumtarihidt);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.Soyadtext);
            this.Controls.Add(this.Adtext);
            this.Controls.Add(this.dogumtarihi);
            this.Controls.Add(this.soyadı);
            this.Controls.Add(this.ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bilgiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyadı;
        private System.Windows.Forms.Label dogumtarihi;
        private System.Windows.Forms.TextBox Adtext;
        private System.Windows.Forms.TextBox Soyadtext;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.DateTimePicker dogumtarihidt;
        private System.Windows.Forms.Label tcnotext;
        private System.Windows.Forms.TextBox tctext;
        private System.Windows.Forms.Label label1;
    }
}