using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("documentclass")]
    public class LaTeXDocumentClassCommand : LaTeXCommand
    {
        public LaTeXDocumentClass DocumentClass { get; set; }

        public LaTeXDocumentClassCommand()
        {
            DocumentClass = LaTeXDocumentClass.Book;
        }

        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn + "{book}\n\n");
        }
    }
}
