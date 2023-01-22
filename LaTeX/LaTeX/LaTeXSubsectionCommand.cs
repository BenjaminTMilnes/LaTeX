using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("subsection")]
    public class LaTeXSubsectionCommand : LaTeXCommand
    {
        public bool IsNumbered { get; set; }
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXSubsectionCommand()
        {
            IsNumbered = true;
            Content = new List<LaTeXCommand>();
        }

        public LaTeXSubsectionCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
