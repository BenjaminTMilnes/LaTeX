using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("begin")]
    public class LaTeXBegin : LaTeXCommand
    {
        public LaTeXEnvironments Environment { get; set; }
    }
}
