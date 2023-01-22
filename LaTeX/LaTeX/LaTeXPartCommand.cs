using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("part")]
    public class LaTeXPartCommand : LaTeXCommand
    {
        public bool IsNumbered { get; set; }
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXPartCommand()
        {
            IsNumbered = true;
            Content = new List<LaTeXCommand>();
        }

        public LaTeXPartCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
