using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("maketitle")]
    public class LaTeXIncludeTitle : LaTeXCommand
    {
        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn + "\n\n");
        }
    }
}
