using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("subsection")]
    public class LaTeXSubsection : LaTeXCommand
    {
        public string AlternativeHeadingText { get; set; }
        public bool IsNumbered { get; set; }
    }
}
