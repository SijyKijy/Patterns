using Patterns.Patterns.Structural.Composite.Interfaces;
using System;
using System.Collections.Generic;

namespace Patterns.Patterns.Structural.Composite.Models
{
    public class Box : Component
    {
        private List<Component> childrens = new List<Component>();

        public override bool IsComposite => true;

        // Constructor
        public Box(string name) : base(name) { }

        public void Add(Component component) => childrens.Add(component);

        public void Remove(Component component) => childrens.Remove(component);

        public override void Display()
        {
            if (childrens.Count == 0)
            {
                Console.WriteLine("Коробка пуста");
            }
            else
            {
                Console.WriteLine($"Count: {childrens.Count}");
                foreach (var children in childrens)
                {
                    children.Display();
                }
            }
        }
    }
}
