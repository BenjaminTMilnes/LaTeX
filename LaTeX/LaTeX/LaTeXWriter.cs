using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LaTeX
{
    public class LaTeXWriter : IDisposable
    {
        protected StreamWriter _streamWriter;

        public LaTeXWriter(string filePath)
        {
            _streamWriter = new StreamWriter(filePath);
        }

        public void WriteCommand(LaTeXCommand command)
        {
            if (command is LaTeXDocumentClassCommand)
            {
                var c = command as LaTeXDocumentClassCommand;

                _streamWriter.Write("\\documentclass{book}\n\n");
            }
            else if (command is LaTeXBeginCommand)
            {
                var c = command as LaTeXBeginCommand;

                if (c.Environment == LaTeXEnvironment.Document)
                {
                    _streamWriter.Write("\\begin{document}\n");
                }
            }
            else if (command is LaTeXEndCommand)
            {
                var c = command as LaTeXEndCommand;

                if (c.Environment == LaTeXEnvironment.Document)
                {
                    _streamWriter.Write("\\end{document}\n");
                }
            }
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}
