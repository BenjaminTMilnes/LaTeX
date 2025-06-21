using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("chapter")]
    public class LaTeXChapterCommand : LaTeXContentCommand
    {
        public bool IsNumbered { get; set; }

        public LaTeXChapterCommand() : base()
        {
            IsNumbered = true;
        }

        public LaTeXChapterCommand(string content) : base(content)
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
