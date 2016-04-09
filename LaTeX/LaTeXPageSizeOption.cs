using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTeX
{
    public class LaTeXPageSizeOption : ILaTeXDocumentClassOption
    {
        public LaTeXPageSizes PageSize { get; set; }
    }
}
