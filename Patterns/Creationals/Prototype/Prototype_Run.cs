using Patterns.Creationals.Prototype.Models;
using System;

namespace Patterns.Creationals.Prototype
{
    public class Prototype_Run
    {
        public Prototype_Run()
        {
            Employee employee1 = new Employee()
            {
                Age = 30,
                Name = "Johnny",
                Work = new Work() { Name = "Janitor" }
            };

            Employee employee2 = employee1.ShallowClone();
            Employee employee3 = employee1.DeepClone();

            // Выводим оригинальные значения
            Console.WriteLine("Original:");

            Console.Write("Emp1 || ");
            employee1.PrintMe();

            Console.Write("Emp2 || ");
            employee2.PrintMe();

            Console.Write("Emp3 || ");
            employee3.PrintMe();

            // Повышаем и меняем возраст Джонни
            employee1.Work.Name = "Chief Janitor";
            employee1.Age = 35;

            // Повторно смотрим значения
            Console.WriteLine("Changed:");

            Console.Write("Emp1 || ");
            employee1.PrintMe();

            Console.Write("Emp2 || "); // Work не меняется из-за MemberwiseClone()
            employee2.PrintMe();

            Console.Write("Emp3 || "); // Скопировали всё ручками
            employee3.PrintMe();
        }
    }
}
