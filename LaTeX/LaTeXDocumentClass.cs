using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("documentclass")]
    public class LaTeXDocumentClass : LaTeXCommand
    {
        public LaTeXDocumentClasses DocumentClass { get; set; }
        public IList<ILaTeXDocumentClassOption> Options { get; set; }
    }
}
