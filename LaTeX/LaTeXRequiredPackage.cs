using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LaTeXRequiredPackage : Attribute
    {
        public string PackageName { get; private set; }

        public LaTeXRequiredPackage(string packageName)
        {
            PackageName = packageName;
        }
    }
}
