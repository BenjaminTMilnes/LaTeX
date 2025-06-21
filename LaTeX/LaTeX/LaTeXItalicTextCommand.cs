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

        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn);
            latexWriter.Write("{");
            latexWriter.WriteCommands(Content);
            latexWriter.Write("}");
        }
    }
}
