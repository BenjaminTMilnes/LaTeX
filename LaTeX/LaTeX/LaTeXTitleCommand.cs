using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("title")]
    public class LaTeXTitleCommand : LaTeXContentCommand
    {
        public LaTeXTitleCommand() : base()
        {
        }

        public LaTeXTitleCommand(string content) : base(content)
        {
        }
    }
}
