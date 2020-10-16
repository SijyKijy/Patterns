using Patterns.Modules;
using Patterns.Patterns.Behavioral.Template_Method.Interfaces;
using Patterns.Patterns.Behavioral.Template_Method.Templates;
using System;

namespace Patterns.Patterns.Behavioral.Template_Method
{
    public class TemplateMethod_Run : AbstractPattern, IBehavioral
    {
        public override string Name => "Шаблонный метод / Template Method";

        public override void Run()
        {
            Console.WriteLine("Обычный парсер:");
            Run(new Parser());

            Console.WriteLine("Парсер с хуком:");
            Run(new ParserWithHook());
        }

        private void Run(AbstractParser parser) => parser.Parse();
    }
}
