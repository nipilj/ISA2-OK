using System;
using System.IO;
using System.Net;

namespace Namespaces_and_.NET_Class_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText("WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
