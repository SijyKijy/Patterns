using Patterns.PatternsExample.Structural.Proxy.Interfaces;
using System;
using System.Threading.Tasks;

namespace Patterns.PatternsExample.Structural.Proxy.Models
{
    public class Server : IServer
    {
        public Server()
        {
            Console.WriteLine("Подключение к серверу...");
            Task.Delay(1000).Wait();
        }

        public string Get() => "<html> Супер-страничка </html>";

        public void Post(string param) => Console.WriteLine($"<html> Супер-страничка с параметрами: {param} </html>");
    }
}
