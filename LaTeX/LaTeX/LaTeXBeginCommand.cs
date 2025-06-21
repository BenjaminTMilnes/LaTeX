using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("begin")]
    public class LaTeXBeginCommand : LaTeXCommand
    {
        public LaTeXEnvironment Environment { get; set; }

        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            if (Environment == LaTeXEnvironment.Document)
            {
                latexWriter.Write("\n\\" + cn + "{document}\n\n");
            }
            else if (Environment == LaTeXEnvironment.FlushLeft)
            {
                latexWriter.Write("\\" + cn + "{flushleft}\n");
            }
            else if (Environment == LaTeXEnvironment.FlushRight)
            {
                latexWriter.Write("\\" + cn + "{flushright}\n");
            }
            else if (Environment == LaTeXEnvironment.Centre)
            {
                latexWriter.Write("\\" + cn + "{center}\n");
            }
            else if (Environment == LaTeXEnvironment.Enumeration)
            {
                latexWriter.Write("\\" + cn + "{enumerate}\n");
            }
        }
    }
}
