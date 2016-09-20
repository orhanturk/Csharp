using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Timers;

namespace ComputerService
{
    public partial class Scheduler : ServiceBase
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("user32")]
        public static extern void LockWorkStation();
        private Timer timer1 = null;

        public Scheduler()
        {
            InitializeComponent();
        }
        protected override void OnSessionChange(SessionChangeDescription changeDescription)
        {
            switch (changeDescription.Reason)
            {
                case SessionChangeReason.SessionLogon:
                    Library.WriteErrorLog("Bilgisayar Açılış Saati: \t " + DateTime.Now);
                    break;
                case SessionChangeReason.SessionLogoff:
                    Library.WriteErrorLog("Bilgisayar Kapanış Saati: \t " + DateTime.Now);
                    break;
                case SessionChangeReason.RemoteConnect:
                    Library.WriteErrorLog("Uzak Bağlantı Açılış Saati: \t " + DateTime.Now);
                    break;
                case SessionChangeReason.RemoteDisconnect:
                    Library.WriteErrorLog("Uzak Bağlantı Kapanış Saati: \t " + DateTime.Now);
                    break;
                case SessionChangeReason.SessionLock:
                    Library.WriteErrorLog("Oturum Kilitleme Saati: \t" + DateTime.Now);
                    break;
                case SessionChangeReason.SessionUnlock:
                    Library.WriteErrorLog("Oturum Açma Saati: \t " + DateTime.Now);
                    break;
                default:
                    break;
            }
        }
        protected override void OnStart(string[] args)
        {

            timer1 = new Timer();
            this.timer1.Interval = 30000; //every 30 secs
            this.timer1.Elapsed += new ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;


            Library.WriteErrorLog("Servis Başladı");

        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            string _username = Library.GetComputerName();

            string _ipadres = Library.GetIpAddress();

            Library.NewRegister();

            string _command = Library.CommandControl(_username);

            if (_command.Length > 2)
            {
                DoOperation(_command);
            }
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Servis Durduruldu");
        }
        private void DoOperation(string oparation)
        {
            string filename = string.Empty;
            string arguments = string.Empty;
            string _username = Library.GetComputerName();
            switch (oparation)
            {
                case "ShutDown":
                    Library.DeleteCommand(_username);
                    Library.WriteErrorLog("Kapat Komutu Çalıştırıldı");
                    var shutdown = new ProcessStartInfo("shutdown", "/s /t 0");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                    //  filename = "shutdown.exe";
                    //arguments = "-s";
                    break;
                case "Restart":
                    Library.DeleteCommand(_username);
                    Library.WriteErrorLog("Yeniden Başlat Komutu Çalıştırıldı");
                    var rebbbot = new ProcessStartInfo("shutdown", "/r /t 0");
                    rebbbot.CreateNoWindow = true;
                    rebbbot.UseShellExecute = false;
                    Process.Start(rebbbot);
                    //filename = "shutdown.exe";
                    //arguments = "-r";
                    break;

                    /*
                case "Logoff":
                    Library.WriteErrorLog("Oturum Kapat Komutu Çalıştırıldı");
                    ExitWindowsEx(0, 0);
                    // filename = "shutdown.exe";
                    //arguments = "-l";
                    break;
                case "Lock":
                    Library.WriteErrorLog("Kitleme Komutu Çalıştırıldı");
                    //LockWorkStation();
                    //filename = "Rundll32.exe";
                    //arguments = "User32.dll, LockWorkStation";
                    break;
                    /*
                case "Hibernation":
                    Library.WriteErrorLog("Bekleme Modu Komutu Çalıştırıldı");
                    filename = @"%windir%\system32\rundll32.exe";
                    arguments = "PowrProf.dll, SetSuspendState";
                    break;
                case "Sleep":
                    Library.WriteErrorLog("Uyku Modu Komutu Çalıştırıldı");
                    filename = "Rundll32.exe";
                    arguments = "powrprof.dll, SetSuspendState 0,1,0";
                    break;
                    */
            }
            /*
            ProcessStartInfo startinfo = new ProcessStartInfo(filename, arguments);
            Process.Start(startinfo);
            */
        }
    }
}
