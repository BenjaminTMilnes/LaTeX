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
