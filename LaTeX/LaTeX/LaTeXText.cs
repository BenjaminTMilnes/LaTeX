using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXText : LaTeXCommand
    {
        public string Content { get; set; }

        public LaTeXText()
        {
            Content = "";
        }

        public LaTeXText(string content)
        {
            Content = content;
        }

        public override void Write(LaTeXWriter latexWriter)
        {
            latexWriter.WriteText(Content);
        }
    }
}
