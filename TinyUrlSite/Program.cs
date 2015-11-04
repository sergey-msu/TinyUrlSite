using System;
using NFX;
using NFX.ApplicationModel;
using NFX.Wave;

namespace TinyUrlSite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                using (var server = new WaveServer())
                {
                    server.Configure(null);
                    server.Start();
                    Console.WriteLine("Web server started at {0}.", DateTime.Now);
                    Console.WriteLine("Press <ENTER> to terminate...");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Critical error:");
                Console.WriteLine(ex.ToMessageWithType());
                Environment.ExitCode = -1;
            }
        }
    }
}
