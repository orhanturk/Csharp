namespace PfWindowsBackupTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_otoyedek = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_saat = new System.Windows.Forms.MaskedTextBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.txt_kuladi = new System.Windows.Forms.TextBox();
            this.txt_sunucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_yedekle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tmrsaat = new System.Windows.Forms.Timer(this.components);
            this.lbl_saat = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.txt_log = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_otoyedek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_saat);
            this.groupBox1.Controls.Add(this.txt_parola);
            this.groupBox1.Controls.Add(this.txt_kuladi);
            this.groupBox1.Controls.Add(this.txt_sunucu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PF Sunucu Bilgileri";
            // 
            // chk_otoyedek
            // 
            this.chk_otoyedek.AutoSize = true;
            this.chk_otoyedek.Location = new System.Drawing.Point(174, 97);
            this.chk_otoyedek.Name = "chk_otoyedek";
            this.chk_otoyedek.Size = new System.Drawing.Size(77, 17);
            this.chk_otoyedek.TabIndex = 6;
            this.chk_otoyedek.Text = "Oto Yedek";
            this.chk_otoyedek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Her Gün";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_saat
            // 
            this.txt_saat.Location = new System.Drawing.Point(110, 95);
            this.txt_saat.Mask = "00:00";
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(58, 20);
            this.txt_saat.TabIndex = 4;
            this.txt_saat.Text = "0000";
            this.txt_saat.ValidatingType = typeof(System.DateTime);
            // 
            // txt_parola
            // 
            this.txt_parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_parola.Location = new System.Drawing.Point(110, 69);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '*';
            this.txt_parola.Size = new System.Drawing.Size(121, 20);
            this.txt_parola.TabIndex = 2;
            // 
            // txt_kuladi
            // 
            this.txt_kuladi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kuladi.Location = new System.Drawing.Point(110, 42);
            this.txt_kuladi.Name = "txt_kuladi";
            this.txt_kuladi.Size = new System.Drawing.Size(121, 20);
            this.txt_kuladi.TabIndex = 1;
            // 
            // txt_sunucu
            // 
            this.txt_sunucu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sunucu.Location = new System.Drawing.Point(110, 16);
            this.txt_sunucu.Name = "txt_sunucu";
            this.txt_sunucu.Size = new System.Drawing.Size(121, 20);
            this.txt_sunucu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu Adresi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(299, 34);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 99);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_kaydet, "Kaydet");
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_yedekle
            // 
            this.btn_yedekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_yedekle.Image")));
            this.btn_yedekle.Location = new System.Drawing.Point(380, 34);
            this.btn_yedekle.Name = "btn_yedekle";
            this.btn_yedekle.Size = new System.Drawing.Size(75, 99);
            this.btn_yedekle.TabIndex = 4;
            this.btn_yedekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_yedekle, "Yedekle");
            this.btn_yedekle.UseVisualStyleBackColor = true;
            this.btn_yedekle.Click += new System.EventHandler(this.btn_yedekle_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(461, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 99);
            this.button1.TabIndex = 14;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button1, "Çıkış");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrsaat
            // 
            this.tmrsaat.Enabled = true;
            this.tmrsaat.Interval = 1000;
            this.tmrsaat.Tick += new System.EventHandler(this.tmrsaat_Tick);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.ForeColor = System.Drawing.Color.Red;
            this.lbl_saat.Location = new System.Drawing.Point(369, 12);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 18);
            this.lbl_saat.TabIndex = 13;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 60000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.Black;
            this.txt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_log.ForeColor = System.Drawing.Color.Lime;
            this.txt_log.Location = new System.Drawing.Point(18, 148);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(518, 203);
            this.txt_log.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 352);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_yedekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFSENSE AUTO BACKUP TOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.TextBox txt_kuladi;
        private System.Windows.Forms.TextBox txt_sunucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_yedekle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chk_otoyedek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_saat;
        private System.Windows.Forms.Timer tmrsaat;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_log;
    }
}

