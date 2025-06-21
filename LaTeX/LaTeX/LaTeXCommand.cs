using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    /// <summary>
    /// An abstract base class for LaTeX commands. A LaTeX document is conceived of as a sequence of commands. A 'command' in this case is quite broad. Commands that start with a backslash, such as the \textbf command, are included, but comments, text, paragraphs, and even white-space are included too. 
    /// </summary>
    public abstract class LaTeXCommand
    {
        public virtual void Write(LaTeXWriter latexWriter)
        {
        }
    }
}
