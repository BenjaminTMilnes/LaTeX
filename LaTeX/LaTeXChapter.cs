using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("chapter")]
    public class LaTeXChapter : LaTeXCommand
    {
        public string AlternativeHeadingText { get; set; }
        public bool IsNumbered { get; set; }
    }
}
