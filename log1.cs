
using Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


using System;


namespace LoggingDemo
{
    
    public static class log1
    {
        public static void SetupTest()
        {
            //Step 3: Create ServiceCollection Object
            var serviceCollection = new ServiceCollection();

            //----------------------------------------------------
            //Step 4: Configure Dependencies/Services
            serviceCollection.AddLogging(builder => builder
                                .AddConsole()
                                .AddDebug()
            );

            //Step 5: Get serviceProvider to use later to get services/instances
            var serviceProvider = serviceCollection.BuildServiceProvider();


            //We need to Provide Category. We may pass Our class as T to ILogger
            ILogger logger = serviceProvider.GetService<ILogger<Program>>();
            logger.Log(LogLevel.Information, "logging framework!");
            logger.LogInformation("Logging framework!");
            logger.Logwarning("logging framework!");
            logger.LogWarning("logging framework!");


            //Templating
            var id = 100;
            logger.LogInformation("logging framework! {id}", id);


            //Or We can use ILoggerFactory and create Logger by Providing Category as String
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            var logger2 = loggerFactory.CreateLogger("pod5logging.Program");
            logger2.LogInformation("Testing1234");

        }
    }
}