using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXParagraph : LaTeXContentCommand
    {
        public LaTeXParagraph() : base()
        {
        }

        public LaTeXParagraph(string content) : base(content)
        {
        }

        public override void Write(LaTeXWriter latexWriter)
        {
            latexWriter.WriteCommands(Content);
            latexWriter.Write("\n\n");
        }
    }
}
