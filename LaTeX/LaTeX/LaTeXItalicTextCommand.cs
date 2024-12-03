using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("textit")]
    public class LaTeXItalicTextCommand : LaTeXContentCommand
    {
        public LaTeXItalicTextCommand() : base()
        {
        }

        public LaTeXItalicTextCommand(string content) : base(content)
        {
        }
    }
}
