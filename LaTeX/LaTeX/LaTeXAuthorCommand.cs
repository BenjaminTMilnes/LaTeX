using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("author")]
    public class LaTeXAuthorCommand : LaTeXContentCommand
    {
        public LaTeXAuthorCommand() : base()
        {
        }

        public LaTeXAuthorCommand(string content) : base(content)
        {
        }
    }
}
