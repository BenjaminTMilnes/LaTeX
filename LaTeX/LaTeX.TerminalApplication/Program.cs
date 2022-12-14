using System;

namespace LaTeX.TerminalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var command1 = new LaTeXDocumentClassCommand();
            var command4 = new LaTeXUsePackageCommand("multicol");
            var command5 = new LaTeXUsePackageCommand("tikz");
            var command2 = new LaTeXBeginCommand();
            var command3 = new LaTeXEndCommand();

            command2.Environment = LaTeXEnvironment.Document;
            command3.Environment = LaTeXEnvironment.Document;

            using (var latexWriter = new LaTeXWriter(@"..\..\..\..\output.tex"))
            {
                latexWriter.WriteCommand(command1);
                latexWriter.WriteCommand(command4);
                latexWriter.WriteCommand(command5);
                latexWriter.WriteCommand(command2);
                latexWriter.WriteCommand(command3);
            }
        }
    }
}
