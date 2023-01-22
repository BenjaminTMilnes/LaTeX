using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("title")]
    public class LaTeXTitleCommand : LaTeXCommand
    {
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXTitleCommand()
        {
            Content = new List<LaTeXCommand>();
        }

        public LaTeXTitleCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
