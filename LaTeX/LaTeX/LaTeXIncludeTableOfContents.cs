using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("tableofcontents")]
    public class LaTeXIncludeTableOfContents : LaTeXCommand
    {
        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn + "\n\n");
        }
    }
}
