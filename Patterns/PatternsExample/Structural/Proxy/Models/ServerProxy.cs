using Patterns.PatternsExample.Structural.Proxy.Interfaces;
using System;

namespace Patterns.PatternsExample.Structural.Proxy.Models
{
    public class ServerProxy : IServer
    {
        private Server _server;

        public ServerProxy(Server server) => _server = server; // Создаём сервисный объект (реального субъекта). Долго

        public ServerProxy() { } // Не создаём сервисный объект (реального субъекта)

        private void CreateSubject() => _server = new Server();

        public string Get()
        {
            if (_server is null)
                CreateSubject();
            return _server.Get();
        }

        public string GetFast() // Если критично, то можно создать отдельные методы без проверки (Можем получить ошибку)
        {
            Console.WriteLine("Быстрое получение");
            return _server.Get();
        }

        public void Post(string param)
        {
            if (_server is null)
                CreateSubject();
            _server.Post(param);
        }
    }
}
