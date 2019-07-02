namespace UcakBileti
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.btnkapat = new System.Windows.Forms.Button();
            this.cmbnereden = new System.Windows.Forms.ComboBox();
            this.cmbnereye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgidis = new System.Windows.Forms.DateTimePicker();
            this.dtdonus = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picKalkis = new System.Windows.Forms.PictureBox();
            this.picInis = new System.Windows.Forms.PictureBox();
            this.picBoxCalendar2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnucusara = new System.Windows.Forms.Button();
            this.tekyonbtn = new System.Windows.Forms.Button();
            this.gidisdonusbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picKalkis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCalendar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.IndianRed;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.Black;
            this.btnkapat.Location = new System.Drawing.Point(537, 12);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 23);
            this.btnkapat.TabIndex = 31;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // cmbnereden
            // 
            this.cmbnereden.FormattingEnabled = true;
            this.cmbnereden.Location = new System.Drawing.Point(140, 76);
            this.cmbnereden.Name = "cmbnereden";
            this.cmbnereden.Size = new System.Drawing.Size(121, 21);
            this.cmbnereden.TabIndex = 11;
            this.cmbnereden.SelectedValueChanged += new System.EventHandler(this.cmbnereden_SelectedValueChanged);
            // 
            // cmbnereye
            // 
            this.cmbnereye.FormattingEnabled = true;
            this.cmbnereye.Location = new System.Drawing.Point(140, 128);
            this.cmbnereye.Name = "cmbnereye";
            this.cmbnereye.Size = new System.Drawing.Size(121, 21);
            this.cmbnereye.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nereden :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nereye :";
            // 
            // dtgidis
            // 
            this.dtgidis.Location = new System.Drawing.Point(140, 183);
            this.dtgidis.Name = "dtgidis";
            this.dtgidis.Size = new System.Drawing.Size(121, 20);
            this.dtgidis.TabIndex = 36;
            this.dtgidis.ValueChanged += new System.EventHandler(this.dtgidis_ValueChanged);
            // 
            // dtdonus
            // 
            this.dtdonus.Location = new System.Drawing.Point(140, 240);
            this.dtdonus.Name = "dtdonus";
            this.dtdonus.Size = new System.Drawing.Size(121, 20);
            this.dtdonus.TabIndex = 37;
            this.dtdonus.ValueChanged += new System.EventHandler(this.dtdonus_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gidiş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Dönüş Tarihi :";
            // 
            // picKalkis
            // 
            this.picKalkis.BackColor = System.Drawing.Color.Transparent;
            this.picKalkis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picKalkis.BackgroundImage")));
            this.picKalkis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picKalkis.ErrorImage = null;
            this.picKalkis.Location = new System.Drawing.Point(267, 76);
            this.picKalkis.Name = "picKalkis";
            this.picKalkis.Size = new System.Drawing.Size(32, 25);
            this.picKalkis.TabIndex = 41;
            this.picKalkis.TabStop = false;
            // 
            // picInis
            // 
            this.picInis.BackColor = System.Drawing.Color.Transparent;
            this.picInis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInis.BackgroundImage")));
            this.picInis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picInis.ErrorImage = null;
            this.picInis.Location = new System.Drawing.Point(267, 127);
            this.picInis.Name = "picInis";
            this.picInis.Size = new System.Drawing.Size(32, 25);
            this.picInis.TabIndex = 42;
            this.picInis.TabStop = false;
            // 
            // picBoxCalendar2
            // 
            this.picBoxCalendar2.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCalendar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxCalendar2.BackgroundImage")));
            this.picBoxCalendar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxCalendar2.ErrorImage = null;
            this.picBoxCalendar2.Location = new System.Drawing.Point(267, 183);
            this.picBoxCalendar2.Name = "picBoxCalendar2";
            this.picBoxCalendar2.Size = new System.Drawing.Size(32, 25);
            this.picBoxCalendar2.TabIndex = 43;
            this.picBoxCalendar2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(267, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 25);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnucusara
            // 
            this.btnucusara.BackColor = System.Drawing.Color.IndianRed;
            this.btnucusara.Location = new System.Drawing.Point(140, 316);
            this.btnucusara.Name = "btnucusara";
            this.btnucusara.Size = new System.Drawing.Size(121, 49);
            this.btnucusara.TabIndex = 45;
            this.btnucusara.Text = "Uçuş Ara";
            this.btnucusara.UseVisualStyleBackColor = false;
            this.btnucusara.Click += new System.EventHandler(this.btnucusara_Click);
            // 
            // tekyonbtn
            // 
            this.tekyonbtn.BackColor = System.Drawing.Color.IndianRed;
            this.tekyonbtn.Location = new System.Drawing.Point(246, 25);
            this.tekyonbtn.Name = "tekyonbtn";
            this.tekyonbtn.Size = new System.Drawing.Size(97, 32);
            this.tekyonbtn.TabIndex = 47;
            this.tekyonbtn.Text = "Tek Yön";
            this.tekyonbtn.UseVisualStyleBackColor = false;
            this.tekyonbtn.Click += new System.EventHandler(this.tekyonbtn_Click);
            // 
            // gidisdonusbtn
            // 
            this.gidisdonusbtn.BackColor = System.Drawing.Color.IndianRed;
            this.gidisdonusbtn.Location = new System.Drawing.Point(108, 25);
            this.gidisdonusbtn.Name = "gidisdonusbtn";
            this.gidisdonusbtn.Size = new System.Drawing.Size(95, 32);
            this.gidisdonusbtn.TabIndex = 48;
            this.gidisdonusbtn.Text = "Gidiş Dönüş";
            this.gidisdonusbtn.UseVisualStyleBackColor = false;
            this.gidisdonusbtn.Click += new System.EventHandler(this.gidisdonusbtn_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 417);
            this.Controls.Add(this.gidisdonusbtn);
            this.Controls.Add(this.tekyonbtn);
            this.Controls.Add(this.btnucusara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBoxCalendar2);
            this.Controls.Add(this.picInis);
            this.Controls.Add(this.picKalkis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtdonus);
            this.Controls.Add(this.dtgidis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbnereye);
            this.Controls.Add(this.cmbnereden);
            this.Controls.Add(this.btnkapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKalkis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCalendar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.ComboBox cmbnereden;
        private System.Windows.Forms.ComboBox cmbnereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtgidis;
        private System.Windows.Forms.DateTimePicker dtdonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picKalkis;
        private System.Windows.Forms.PictureBox picInis;
        private System.Windows.Forms.PictureBox picBoxCalendar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnucusara;
        private System.Windows.Forms.Button tekyonbtn;
        private System.Windows.Forms.Button gidisdonusbtn;
    }
}