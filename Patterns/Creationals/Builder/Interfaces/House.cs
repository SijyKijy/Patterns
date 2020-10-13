using System;
using System.Collections.Generic;

namespace Patterns.Creationals.Builder.Interfaces
{
    public abstract class House
    {
        public abstract string Material { get; }

        private List<string> _parts = new List<string>();

        public void AddPart(string part) => _parts.Add(part);

        public string GetParts()
        {
            string str = "Детали дома:\n";

            foreach (var part in _parts)
                str += part + Environment.NewLine;

            return str;
        }
    }
}
