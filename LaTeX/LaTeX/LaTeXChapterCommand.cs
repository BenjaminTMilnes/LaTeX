using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("chapter")]
    public class LaTeXChapterCommand : LaTeXCommand
    {
        public bool IsNumbered { get; set; }
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXChapterCommand()
        {
            IsNumbered = true;
            Content = new List<LaTeXCommand>();
        }

        public LaTeXChapterCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
