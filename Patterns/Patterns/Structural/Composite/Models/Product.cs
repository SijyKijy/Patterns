﻿using Patterns.Patterns.Structural.Composite.Interfaces;
using System;

namespace Patterns.Patterns.Structural.Composite.Models
{
    public class Product : Component
    {
        private string _name;

        public Product(string name) : base(name) { _name = name; }

        public override bool IsComposite => false;

        public override void Display() => Console.WriteLine($"Продукт: {_name}");
    }
}
