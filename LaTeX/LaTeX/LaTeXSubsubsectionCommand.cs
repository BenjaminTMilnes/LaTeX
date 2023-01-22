using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("subsubsection")]
    public class LaTeXSubsubsectionCommand : LaTeXCommand
    {
        public bool IsNumbered { get; set; }
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXSubsubsectionCommand()
        {
            IsNumbered = true;
            Content = new List<LaTeXCommand>();
        }

        public LaTeXSubsubsectionCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
