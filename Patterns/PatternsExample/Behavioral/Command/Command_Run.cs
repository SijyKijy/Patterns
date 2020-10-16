using Patterns.Modules;
using System;

namespace Patterns.PatternsExample.Behavioral.Command
{
    public class Command_Run : AbstractPattern, IBehavioral
    {
        public override string Name => "Команда / Command";

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
