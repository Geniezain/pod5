using LoggingDemo;
using System;

namespace Logging
{ 

    class Program
    {
        static void Main(string[]args)
        {
            /* Step 1: Add NuGet Packages 
             * -----------------
             * Add Logging Framework => Microsoft.Extensions.Logging
             * Add DI Framework => Microsoft.Extensions.DependencyInjection
             * Add Console Log Provider => Microsoft.Extensions.Logging.Console
             * -------------
             */

            /* ----For Configuration Demo------, Add following packages
             * Microsoft.Extensions.Configuration
             * Microsoft.Extensions.Configuration.Json
             */

            /* ----For NLog Demo------, Add following packages
             * NLog.Web.AspNetCore
             * NLog
             */


            log1.SetupTest();
            log2.SetupTest();
            log3.SetupTest();
     
            Console.ReadKey();
           
        }
    }
}