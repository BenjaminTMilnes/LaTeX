using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("setcounter")]
    public class LaTeXSetCounter : LaTeXCommand
    {
        public LaTeXCounters Counter { get; set; }
        public int Level { get; set; }
    }
}
