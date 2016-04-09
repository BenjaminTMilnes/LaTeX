using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LaTeXCommandName : Attribute
    {
        public string Name { get; private set; }

        public LaTeXCommandName(string name)
        {
            Name = name;
        }
    }
}
