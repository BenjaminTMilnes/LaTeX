using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("usepackage")]
    public class LaTeXUsePackage : LaTeXCommand
    {
        public string Name { get; set; }
        public IList<ILaTeXUsePackageOption> Options { get; set; }
    }
}
