﻿using Patterns.PatternsExample.Behavioral.Template_Method.Interfaces;
using System;

namespace Patterns.PatternsExample.Behavioral.Template_Method.Templates
{
    public class Parser : AbstractParser
    {
        protected override void ReadHeader() => Console.WriteLine("Считываем заголовок");

        protected override void ReadBody() => Console.WriteLine("Считываем тело");

        protected override void ReadFooter() => Console.WriteLine("Считываем нижний колонтитул");
    }
}
