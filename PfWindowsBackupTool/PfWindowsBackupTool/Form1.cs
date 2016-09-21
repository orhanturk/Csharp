using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace PfWindowsBackupTool
{
    public partial class Form1 : Form
    {
        String _dumpPath = String.Empty;
      
        bool yedeklemecalisiyor = false;
       
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_sunucu.Text = Properties.Settings.Default.pfserver;
            txt_kuladi.Text = Properties.Settings.Default.pfuser;
            txt_parola.Text = Properties.Settings.Default.pfpass;
            txt_saat.Text = Properties.Settings.Default.saat;
            chk_otoyedek.Checked = Convert.ToBoolean(Properties.Settings.Default.aktif);
        }
      
        public void PfBackup()
        {
            VeriLogYaz("PfSense Yedekleme Başlatıldı");
            StreamWriter sw = new StreamWriter("pfbackup.bat");
            StringBuilder strSB = new StringBuilder(_dumpPath);
            strSB.Append("pfsenseBackup.exe -u " + Properties.Settings.Default.pfuser + " -p " + Properties.Settings.Default.pfpass + " -s " + Properties.Settings.Default.pfserver + " -usessl");
            sw.WriteLine(strSB);
            sw.Dispose();
            sw.Close();
            Process processDB = Process.Start("pfbackup.bat");
            do
            {//dont perform anything
            }
            while (!processDB.HasExited);
            {
                /// MessageBox.Show(" Yedekleme Başarılı ");
                VeriLogYaz("PfSense Yedekleme başarılı olarak yedeklendi..");
            }
            VeriLogYaz("******************************************************************");
        }
      
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pfserver = txt_sunucu.Text;
            Properties.Settings.Default.pfuser = txt_kuladi.Text;
            Properties.Settings.Default.pfpass = txt_parola.Text;
            Properties.Settings.Default.saat = txt_saat.Text;
            Properties.Settings.Default.aktif = Convert.ToBoolean(chk_otoyedek.Checked);
            Properties.Settings.Default.Save();
            StreamWriter sw = new StreamWriter("pfbackup.bat");
            StringBuilder strSB = new StringBuilder(_dumpPath);
            strSB.Append("pfsenseBackup.exe -u " + Properties.Settings.Default.pfuser + " -p " + Properties.Settings.Default.pfpass + " -s " + Properties.Settings.Default.pfserver + " -usessl");
            sw.WriteLine(strSB);
            sw.Dispose();
            sw.Close();
            MessageBox.Show("Bilgiler Kaydedildi");
        }
     
        private void btn_yedekle_Click(object sender, EventArgs e)
        {
            PfBackup();
        }
      
        private void tmrsaat_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
      
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (chk_otoyedek.Checked != false)
            {
                string _kayitlisaat = Convert.ToDateTime(Properties.Settings.Default.saat).ToString("HH:mm");
                string saat = Convert.ToDateTime(lbl_saat.Text).ToString("HH:mm");
                if (_kayitlisaat == saat)
                {
                    yedeklemecalisiyor = true;
                    if (yedeklemecalisiyor == true)
                    {
                        PfBackup();
                        yedeklemecalisiyor = false;
                    }
                }
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void VeriLogYaz(string logum)
        {
            txt_log.Text += DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + logum + Environment.NewLine;
            txt_log.SelectionStart = txt_log.Text.Length;
            txt_log.ScrollToCaret();
        }
    }
}
