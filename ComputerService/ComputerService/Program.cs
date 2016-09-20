using System.ServiceProcess;

namespace ComputerService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Scheduler() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
