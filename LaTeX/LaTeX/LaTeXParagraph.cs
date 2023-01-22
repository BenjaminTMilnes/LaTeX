using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXParagraph : LaTeXCommand
    {
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXParagraph()
        {
            Content = new List<LaTeXCommand>();
        }

        public LaTeXParagraph(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
