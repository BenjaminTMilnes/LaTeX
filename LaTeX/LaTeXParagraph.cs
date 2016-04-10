using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("paragraph")]
    public class LaTeXParagraph : LaTeXCommand
    {
        public string AlternativeHeadingText { get; set; }
        public bool IsNumbered { get; set; }
    }
}
