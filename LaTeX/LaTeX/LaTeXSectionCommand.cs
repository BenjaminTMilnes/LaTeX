using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("section")]
    public class LaTeXSectionCommand : LaTeXContentCommand
    {
        public bool IsNumbered { get; set; }

        public LaTeXSectionCommand() : base()
        {
            IsNumbered = true;
        }

        public LaTeXSectionCommand(string content) : base(content)
        {
            IsNumbered = true;
        }
    }
}
