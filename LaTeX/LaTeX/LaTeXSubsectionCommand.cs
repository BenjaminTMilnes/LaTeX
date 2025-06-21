using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("subsection")]
    public class LaTeXSubsectionCommand : LaTeXContentCommand
    {
        public bool IsNumbered { get; set; }

        public LaTeXSubsectionCommand() : base()
        {
            IsNumbered = true;
        }

        public LaTeXSubsectionCommand(string content) : base(content)
        {
            IsNumbered = true;
        }

        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn);

            if (!IsNumbered)
            {
                latexWriter.Write("*");
            }

            latexWriter.Write("{");
            latexWriter.WriteCommands(Content);
            latexWriter.Write("}\n\n");
        }
    }
}
