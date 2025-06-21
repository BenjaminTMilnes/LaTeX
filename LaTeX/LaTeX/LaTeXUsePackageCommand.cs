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

        public override void Write(LaTeXWriter latexWriter)
        {
            var cn = latexWriter.GetCommandName(this);

            latexWriter.Write("\\" + cn + "{" + PackageName + "}\n");
        }
    }
}
