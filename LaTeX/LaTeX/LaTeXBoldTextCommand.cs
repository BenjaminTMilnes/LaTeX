using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("textbf")]
    public class LaTeXBoldTextCommand : LaTeXContentCommand
    {
        public LaTeXBoldTextCommand() : base()
        {
        }

        public LaTeXBoldTextCommand(string content) : base(content)
        {
        }
    }
}
