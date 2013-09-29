using System;
using dotNest;

namespace dotNestConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string username = "";
            const string password = "";

            var nestClient = new NestClient(username, password);
            var structures = nestClient.Status();
            
            Console.ReadLine();
        }
    }
}