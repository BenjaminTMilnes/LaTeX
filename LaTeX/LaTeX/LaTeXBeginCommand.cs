using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("begin")]
    public class LaTeXBeginCommand : LaTeXCommand
    {
        public LaTeXEnvironment Environment { get; set; }
    }
}
