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
