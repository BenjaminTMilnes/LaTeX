using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    /// <summary>
    /// An abstract base class for commands that have inner content. This content is usually text, but can also include other commands.
    /// </summary>
    public abstract class LaTeXContentCommand : LaTeXCommand
    {
        public IList<LaTeXCommand> Content { get; set; }

        public LaTeXContentCommand()
        {
            Content = new List<LaTeXCommand>();
        }

        public LaTeXContentCommand(string content) : this()
        {
            Content.Add(new LaTeXText(content));
        }
    }
}
