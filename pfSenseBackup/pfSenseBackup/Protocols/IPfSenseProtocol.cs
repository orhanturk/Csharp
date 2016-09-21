﻿using System.Net;

namespace pfSenseBackup.pfSenseBackup.Protocols
{
    /// <summary>
    /// Defines the interface to which pfSense protocol handlers must comply
    /// </summary>
    public interface IPfSenseProtocol
    {
        /// <summary>
        /// Connects with the specified pfSense server using the current protocol implementation and returns the backup file contents
        /// </summary>
        /// <param name="pfSenseServer">pfSense server details which identifies which pfSense server to connect to</param>
        /// <param name="cookieJar">Cookie container to use through the communication with pfSense</param>
        /// <returns>PfSenseBackupFile instance containing the retrieved backup content from pfSense</returns>
        PfSenseBackupFile Execute(PfSenseServerDetails pfSenseServer, CookieContainer cookieJar);
    }
}
