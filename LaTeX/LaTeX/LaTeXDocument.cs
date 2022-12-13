using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXDocument
    {
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXDocument()
        {
            Content = new List<LaTeXCommand>();
        }
    }
}
