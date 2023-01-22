using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("section")]
    public class LaTeXSectionCommand : LaTeXCommand
    {
        public bool IsNumbered { get; set; }
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXSectionCommand()
        {
            IsNumbered = true;
            Content = new List<LaTeXCommand>();
        }

        public LaTeXSectionCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
