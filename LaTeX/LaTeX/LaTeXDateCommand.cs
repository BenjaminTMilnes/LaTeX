using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("date")]
    public class LaTeXDateCommand : LaTeXContentCommand
    {
        public LaTeXDateCommand() : base()
        {
        }

        public LaTeXDateCommand(string content) : base(content)
        {
        }

        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn);
            latexWriter.Write("{");
            latexWriter.WriteCommands(Content);
            latexWriter.Write("}\n");
        }
    }
}
