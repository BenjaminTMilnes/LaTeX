using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("subsubsection")]
    public class LaTeXSubsubsectionCommand : LaTeXContentCommand
    {
        public bool IsNumbered { get; set; }

        public LaTeXSubsubsectionCommand() : base()
        {
            IsNumbered = true;
        }

        public LaTeXSubsubsectionCommand(string content) : base(content)
        {
            IsNumbered = true;
        }
    }
}
