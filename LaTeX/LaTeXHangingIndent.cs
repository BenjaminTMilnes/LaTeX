using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("hangindent")]
    public class LaTeXHangingIndent : LaTeXCommand
    {
        public LaTeXLength Length { get; set; }
    }
}
