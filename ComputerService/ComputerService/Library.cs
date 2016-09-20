using System;
using System.IO;
using Npgsql;
using System.Net;

namespace ComputerService
{
    public static class Library
    {
        private static string server = "192.168.2.6";

        private static string database = "servicecontrol";

        private static string username = "servicecontrol";

        private static string password = "mokdakm";


        public static string SqlStr = "Server=" + server + ";Port=5432;Database=" + database + ";User Id=" + username + ";Password=" + password + ";Pooling=false;";

        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Kayit.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Kayit.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        public static void NewRegister()
        {
            string username = GetComputerName();

            string ipadress = GetIpAddress();

            if (username.Length > 2)
            {
                int _regcontrol = NewRegisterControl(username);

                if (_regcontrol == 0)
                {
                    using (NpgsqlConnection cnn = new NpgsqlConnection(SqlStr))
                    {
                        cnn.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into t_user (ip_adres,username) values(@ip_adres,@username)", cnn);
                        cmd.Parameters.AddWithValue("@ip_adres", ipadress);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }
        }

        public static int NewRegisterControl(string username)
        {
            int result = 0;

            using (NpgsqlConnection cnn = new NpgsqlConnection(SqlStr))
            {
                cnn.Open();
                try
                {
                    NpgsqlCommand emir = new NpgsqlCommand("select id from t_user where username='" + username + "'", cnn);
                    result = Convert.ToInt32(emir.ExecuteScalar());
                }
                catch { }
                cnn.Close();
            }
            return result;

        }

        public static string CommandControl(string username)
        {
            string result = "";
            using (NpgsqlConnection cnn = new NpgsqlConnection(SqlStr))
            {
                cnn.Open();
                try
                {
                    NpgsqlCommand emir = new NpgsqlCommand("select command from t_command where username='" + username + "' and statu=true", cnn);
                    result = emir.ExecuteScalar().ToString();
                }
                catch { }
                cnn.Close();
            }
            return result;
        }

        public static void DeleteCommand(string username)
        {
            using (NpgsqlConnection cnn = new NpgsqlConnection(SqlStr))
            {
                cnn.Open();
                try
                {
                    NpgsqlCommand emir = new NpgsqlCommand("delete from t_command where username='" + username + "' and statu=true", cnn);
                    emir.ExecuteNonQuery().ToString();
                }
                catch { }
                cnn.Close();
            }
        }
        public static string GetComputerName()
        {

            string domainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            string hostName = Dns.GetHostName();
            string fqdn = "";
            if (!hostName.Contains(domainName))
                fqdn = hostName + "." + domainName;
            else
                fqdn = hostName;

            return fqdn;
        }

        public static string GetIpAddress()
        {
            string hostName = Dns.GetHostName();

#pragma warning disable CS0618 // Type or member is obsolete
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
#pragma warning restore CS0618 // Type or member is obsolete
            return myIP;
        }
    }
}
