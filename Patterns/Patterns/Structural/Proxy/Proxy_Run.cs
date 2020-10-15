using Patterns.Modules;
using Patterns.Patterns.Structural.Proxy.Models;

namespace Patterns.Patterns.Structural.Proxy
{
    public class Proxy_Run : Pattern, IStructural
    {
        public override string Name => "Заместитель / Proxy";

        public override void Run()
        {
            // Лучше всего пользоваться сервисным объектом (реальным субъектом) через прокси. С тем условием, что объект создаётся внутри.
            System.Console.WriteLine("Создание сервера внутри прокси");
            var serverProxy = new ServerProxy();

            //serverProxy.GetFast(); // NullReferenceException

            System.Console.WriteLine(serverProxy.Get());
            serverProxy.Post("Тестовые параметры");

            // Но ничего не мешает нам его создать заранее
            System.Console.WriteLine("--- --- ---");
            System.Console.WriteLine("Создание сервера заранее");
            var server = new Server();
            var serverProxy2 = new ServerProxy(server);

            System.Console.WriteLine(serverProxy2.GetFast());
            serverProxy2.Post("Тестовые параметры");
        }
    }
}
