using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    [LaTeXCommandName("addcontentsline")]
    public class LaTeXAddContentsLine : LaTeXCommand
    {
        public string TableOfContents { get; set; }
        public LaTeXSectioningLevels Level { get; set; }
        public string Text { get; set; }
    }
}
