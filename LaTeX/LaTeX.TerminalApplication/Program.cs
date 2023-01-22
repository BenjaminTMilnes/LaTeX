using System;

namespace LaTeX.TerminalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = "Grumpy wizards make toxic brew for the Evil Queen and Jack. Grumpy wizards make toxic brew for the Evil Queen and Jack. Grumpy wizards make toxic brew for the Evil Queen and Jack. Grumpy wizards make toxic brew for the Evil Queen and Jack. Grumpy wizards make toxic brew for the Evil Queen and Jack. ";


            var command1 = new LaTeXDocumentClassCommand();
            var command4 = new LaTeXUsePackageCommand("multicol");
            var command5 = new LaTeXUsePackageCommand("tikz");
            var command2 = new LaTeXBeginCommand();
            var command3 = new LaTeXEndCommand();

            command2.Environment = LaTeXEnvironment.Document;
            command3.Environment = LaTeXEnvironment.Document;

            var document = new LaTeXDocument();

            document.Content.Add(command1);
            document.Content.Add(command4);
            document.Content.Add(command5);
            document.Content.Add(command2);

            document.Content.Add(new LaTeXPartCommand("The First Part"));
            document.Content.Add(new LaTeXChapterCommand("The First Chapter"));
            document.Content.Add(new LaTeXSectionCommand("The First Section"));
            document.Content.Add(new LaTeXSubsectionCommand("The First Subsection"));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXSubsectionCommand("The Second Subsection"));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXSubsectionCommand("The Third Subsection"));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXSectionCommand("The Second Section"));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXSectionCommand("The Third Section"));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXChapterCommand("The Second Chapter"));
            document.Content.Add(new LaTeXPartCommand("The Second Part"));
            document.Content.Add(new LaTeXChapterCommand("The First Chapter"));
            document.Content.Add(new LaTeXParagraph(t1));
            document.Content.Add(new LaTeXChapterCommand("The Second Chapter"));
            document.Content.Add(new LaTeXParagraph(t1));

            document.Content.Add(command3);

            using (var latexWriter = new LaTeXWriter(@"..\..\..\..\output.tex"))
            {
                latexWriter.WriteDocument(document);
            }
        }
    }
}
