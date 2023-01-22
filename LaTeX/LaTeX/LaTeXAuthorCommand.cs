using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("author")]
    public class LaTeXAuthorCommand : LaTeXCommand
    {
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXAuthorCommand()
        {
            Content = new List<LaTeXCommand>();
        }

        public LaTeXAuthorCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
