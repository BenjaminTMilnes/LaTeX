using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    [LaTeXCommandName("usepackage")]
    public class LaTeXUsePackageCommand : LaTeXCommand
    {
        public string PackageName { get; set; }

        public LaTeXUsePackageCommand(string packageName)
        {
            PackageName = packageName;
        }
    }
}
