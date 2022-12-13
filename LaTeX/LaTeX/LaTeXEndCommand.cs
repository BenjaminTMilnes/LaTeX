using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("end")]
    public class LaTeXEndCommand : LaTeXCommand
    {
        public LaTeXEnvironment Environment { get; set; }
    }
}
