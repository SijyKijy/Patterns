using System;

namespace Patterns.PatternsExample.Creationals.Prototype.Models
{
    public class Employee : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Work Work { get; set; }

        public Employee ShallowClone() =>
            (Employee)MemberwiseClone();

        public Employee DeepClone()
        {
            Employee clone = (Employee)MemberwiseClone();
            clone.Work = new Work() { Name = Work.Name };

            return clone;
        }

        public void PrintMe() => Console.WriteLine($"Age: {Age} | Name: {Name} | Work: {Work.Name}");

        public object Clone() // В C# для этого паттерна для ICloneable
             => (Employee)MemberwiseClone();
    }
}
