using Microsoft.Crm.Sdk.Samples.HelperCode;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();

            try
            {
                //Get arguments
                string[] arguments = Environment.GetCommandLineArgs();

                //Connect to Dynamics CRM
                var httpClient = CrmAction.ConnectToCRM(arguments);

                if (httpClient != null)
                {
                    //Call Api
                    CrmAction.CallerAsync(httpClient).Wait();

                    //Dispose
                    httpClient.Dispose();
                }

            }
            catch (Exception ex)
            {                
                CrmAction.DisplayException(ex);
            }

            Console.ReadKey();

        }

    }
}
