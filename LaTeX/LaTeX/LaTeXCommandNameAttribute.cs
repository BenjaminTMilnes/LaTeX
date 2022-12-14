using System;
using System.Collections.Generic;
using System.Text;

namespace LaTeX
{
    public class LaTeXCommandNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public LaTeXCommandNameAttribute(string name)
        {
            Name = name;
        }
    }
}
