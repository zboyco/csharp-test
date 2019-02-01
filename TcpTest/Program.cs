using System;
using System.Net;
using System.Net.Sockets;

namespace TcpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TcpListener listener = new TcpListener(IPAddress.Any, 9043);
            listener.Start();
            Console.WriteLine("TcpListener Success!");
            Console.ReadKey();
        }
    }
}
