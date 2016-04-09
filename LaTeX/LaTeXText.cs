using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    public class LaTeXText
    {
        public string Content { get; set; }

        public LaTeXText() { }

        public LaTeXText(string content)
        {
            Content = content;
        }
    }
}
