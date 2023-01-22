using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("part")]
    public class LaTeXPartCommand : LaTeXContentCommand
    {
        public bool IsNumbered { get; set; }

        public LaTeXPartCommand() : base()
        {
            IsNumbered = true;
        }

        public LaTeXPartCommand(string content) : base(content)
        {
            IsNumbered = true;
        }
    }
}
