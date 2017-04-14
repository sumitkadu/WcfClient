using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //WcfService.RestServiceClient client = new WcfService.RestServiceClient();
            //string content = client.GetData();

            RemoteWcfHost.RestServiceClient client = new RemoteWcfHost.RestServiceClient();
            string content = client.GetData();

            Console.Write(content);
            Console.ReadLine();
        }
    }
}
