using System;
using System.IO;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WcfService.RestServiceClient client = new WcfService.RestServiceClient();

            using (StreamReader reader = new StreamReader("Output.json"))
            {
                string content = reader.ReadToEnd();
                string status = client.PostData(content);
                Console.Write(status);
                reader.Close();
            }

               

            //RemoteWcfHost.RestServiceClient client = new RemoteWcfHost.RestServiceClient();
            //string content = client.GetData();

            
            Console.ReadLine();
        }
    }
}
