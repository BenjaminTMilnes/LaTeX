using System;
using System.Collections.Generic;
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
    }
}
