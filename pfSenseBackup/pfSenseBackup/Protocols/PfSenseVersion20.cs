﻿using System;
using System.Collections.Generic;
using System.Net;

namespace pfSenseBackup.pfSenseBackup.Protocols
{
    /// <summary>
    /// Implementation of the pfSense protocol for version 2.0
    /// </summary>
    public class PfSenseVersion20 : IPfSenseProtocol
    {
        /// <summary>
        /// Connects with the specified pfSense server using the v2.0 protocol implementation and returns the backup file contents
        /// </summary>
        /// <param name="pfSenseServer">pfSense server details which identifies which pfSense server to connect to</param>
        /// <param name="cookieJar">Cookie container to use through the communication with pfSense</param>
        /// <returns>PfSenseBackupFile instance containing the retrieved backup content from pfSense</returns>
        public PfSenseBackupFile Execute(PfSenseServerDetails pfSenseServer, CookieContainer cookieJar)
        {
            Program.WriteOutput("Connecting using protocol version {0}", new object[] { pfSenseServer.Version });

            // Create a session on the pfSense webserver
            HttpUtility.HttpCreateSession(pfSenseServer.ServerBaseUrl, cookieJar);

            Program.WriteOutput("Authenticating");

            // Authenticate the session
            var authenticationResult = HttpUtility.AuthenticateViaUrlEncodedFormMethod(string.Concat(pfSenseServer.ServerBaseUrl, "index.php"),
                                                                                       new Dictionary<string, string>
                                                                                       {
                                                                                            { "usernamefld", pfSenseServer.Username }, 
                                                                                            { "passwordfld", pfSenseServer.Password }, 
                                                                                            { "login", "Login" }
                                                                                       },
                                                                                       cookieJar);

            // Verify if the username/password combination was valid by examining the server response
            if (authenticationResult.Contains("Username or Password incorrect"))
            {
                throw new ApplicationException("ERROR: Credentials incorrect");
            }

            Program.WriteOutput("Retrieving backup file");

            var downloadArgs = new Dictionary<string, string>
                {
                    { "donotbackuprrd", pfSenseServer.BackupStatisticsData ? "" : "on" },
                    { "nopackages", pfSenseServer.BackupPackageInfo ? "" : "on" },
                    { "Submit", "Download configuration" }
                };

            string filename;
            var pfSenseBackupFile = new PfSenseBackupFile
            {
                FileContents = HttpUtility.DownloadBackupFile(string.Concat(pfSenseServer.ServerBaseUrl, "diag_backup.php"),
                                                                downloadArgs,
                                                                cookieJar,
                                                                out filename),
                FileName = filename
            };
            return pfSenseBackupFile;
        }
    }
}
