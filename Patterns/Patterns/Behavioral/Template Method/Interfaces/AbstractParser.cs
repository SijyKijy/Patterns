using System;

namespace Patterns.Patterns.Behavioral.Template_Method.Interfaces
{
    public abstract class AbstractParser
    {
        /// <summary>
        /// Шаблонный метод
        /// </summary>
        public void Parse()
        {
            NotifyStart();
            Hook1();
            ReadHeader();
            ReadBody();
            ReadFooter();
            Hook2();
        }

        // Метод который не требуется переопределять
        protected void NotifyStart() => Console.WriteLine("Начинаем парсить...");

        // Методы требующие реализации
        protected abstract void ReadHeader();
        protected abstract void ReadBody();
        protected abstract void ReadFooter();

        // Не обязательно, но можно добавить хуки для критических случаев
        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}
