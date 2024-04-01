using System;
using System.Net;
using System.Net.Sockets;

namespace Server_Socket
{
    public class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();
            while (true)
                server.Update();
        }
    }
}