using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXCommandName : Attribute
    {
        public string Name { get; private set; }

        public LaTeXCommandName(string name)
        {
            Name = name;
        }
    }
}
