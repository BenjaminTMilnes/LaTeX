using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXComment : LaTeXCommand
    {
        public string Content { get; set; }

        public LaTeXComment()
        {
            Content = "";
        }

        public LaTeXComment(string content)
        {
            Content = content;
        }
    }
}
