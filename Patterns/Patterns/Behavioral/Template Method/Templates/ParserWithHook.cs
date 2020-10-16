using Patterns.Patterns.Behavioral.Template_Method.Interfaces;
using System;

namespace Patterns.Patterns.Behavioral.Template_Method.Templates
{
    public class ParserWithHook : AbstractParser
    {
        protected override void ReadHeader() => Console.WriteLine("Считываем заголовок");

        protected override void ReadBody() => Console.WriteLine("Считываем тело");

        protected override void ReadFooter() => Console.WriteLine("Считываем нижний колонтитул");

        protected override void Hook2() => Console.WriteLine("Заканчиваем парсить");
    }
}
