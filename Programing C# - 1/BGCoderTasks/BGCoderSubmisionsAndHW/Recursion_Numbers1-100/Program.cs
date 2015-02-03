using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Numbers1_100
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //String direction = "";
            //WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            //using (WebResponse response = request.GetResponse())
            //using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            //{
            //    direction = stream.ReadToEnd();
            //}

            ////Search for the ip in the html
            //int first = direction.IndexOf("Address: ") + 9;
            //int last = direction.LastIndexOf("</body>");
            //direction = direction.Substring(first, last - first);
            Console.WriteLine(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork));
          //  Console.WriteLine("HostName: " + Dns.GetHostName() + "\nIP Address: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString());
        }

        private static void Recursion(int start, int stop, int current) 
        {
            for (int i = start; i <= current; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            if (current == stop)
	        {
		        return;
	        }
            Recursion(start, stop, current + 1);
        }
    }
}
