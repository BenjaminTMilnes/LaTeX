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

        public void WriteDocument(LaTeXDocument document)
        {
            WriteCommands(document.Content);
        }

        public string GetCommandName(LaTeXCommand command)
        {
            var commandNameAttributes = command.GetType().GetCustomAttributes(typeof(LaTeXCommandNameAttribute), true);

            if (commandNameAttributes.Length > 0)
            {
                var commandNameAttribute = commandNameAttributes[0] as LaTeXCommandNameAttribute;

                return commandNameAttribute.Name;
            }

            return "";
        }

        public void WriteCommand(string name)
        {
            Write("\\" + name);
        }

        public void WriteCommands(IList<LaTeXCommand> commands)
        {
            foreach (var command in commands)
            {
                WriteCommand(command);
            }
        }

        public void WriteCommand(LaTeXCommand command)
        {
            var cn = GetCommandName(command);

            if (command is LaTeXDocumentClassCommand)
            {
                var c = command as LaTeXDocumentClassCommand;

                Write("\\" + cn + "{book}\n\n");
            }
            else if (command is LaTeXUsePackageCommand)
            {
                var c = command as LaTeXUsePackageCommand;

                Write("\\" + cn + "{" + c.PackageName + "}\n");
            }
            else if (command is LaTeXBeginCommand)
            {
                var c = command as LaTeXBeginCommand;

                if (c.Environment == LaTeXEnvironment.Document)
                {
                    Write("\n\\" + cn + "{document}\n\n");
                }
                else if (c.Environment == LaTeXEnvironment.FlushLeft)
                {
                    Write("\\" + cn + "{flushleft}\n");
                }
                else if (c.Environment == LaTeXEnvironment.FlushRight)
                {
                    Write("\\" + cn + "{flushright}\n");
                }
                else if (c.Environment == LaTeXEnvironment.Centre)
                {
                    Write("\\" + cn + "{center}\n");
                }
                else if (c.Environment == LaTeXEnvironment.Enumeration)
                {
                    Write("\\" + cn + "{enumerate}\n");
                }
            }
            else if (command is LaTeXEndCommand)
            {
                var c = command as LaTeXEndCommand;

                if (c.Environment == LaTeXEnvironment.Document)
                {
                    Write("\\" + cn + "{document}\n");
                }
                else if (c.Environment == LaTeXEnvironment.FlushLeft)
                {
                    Write("\\" + cn + "{flushleft}\n");
                }
                else if (c.Environment == LaTeXEnvironment.FlushRight)
                {
                    Write("\\" + cn + "{flushright}\n");
                }
                else if (c.Environment == LaTeXEnvironment.Centre)
                {
                    Write("\\" + cn + "{center}\n");
                }
                else if (c.Environment == LaTeXEnvironment.Enumeration)
                {
                    Write("\\" + cn + "{enumerate}\n");
                }
            }
            else if (command is LaTeXPartCommand)
            {
                var c = command as LaTeXPartCommand;

                Write("\\" + cn);

                if (!c.IsNumbered)
                {
                    Write("*");
                }

                Write("{");
                WriteCommands(c.Content);
                Write("}\n\n");
            }
            else if (command is LaTeXChapterCommand)
            {
                var c = command as LaTeXChapterCommand;

                Write("\\" + cn);

                if (!c.IsNumbered)
                {
                    Write("*");
                }

                Write("{");
                WriteCommands(c.Content);
                Write("}\n\n");
            }
            else if (command is LaTeXSectionCommand)
            {
                var c = command as LaTeXSectionCommand;

                Write("\\" + cn);

                if (!c.IsNumbered)
                {
                    Write("*");
                }

                Write("{");
                WriteCommands(c.Content);
                Write("}\n\n");
            }
            else if (command is LaTeXSubsectionCommand)
            {
                var c = command as LaTeXSubsectionCommand;

                Write("\\" + cn);

                if (!c.IsNumbered)
                {
                    Write("*");
                }

                Write("{");
                WriteCommands(c.Content);
                Write("}\n\n");
            }
            else if (command is LaTeXSubsubsectionCommand)
            {
                var c = command as LaTeXSubsubsectionCommand;

                Write("\\" + cn);

                if (!c.IsNumbered)
                {
                    Write("*");
                }

                Write("{");
                WriteCommands(c.Content);
                Write("}\n\n");
            }
            else if (command is LaTeXParagraph)
            {
                var c = command as LaTeXParagraph;

                WriteCommands(c.Content);
                Write("\n\n");
            }
            else if (command is LaTeXText)
            {
                var c = command as LaTeXText;

                WriteText(c.Content);
            }
            else if (command is LaTeXComment)
            {
                var c = command as LaTeXComment;

                WriteComment(c.Content);
            }
            else
            {
                throw new Exception($"Unknown command {command.GetType()}.");
            }
        }

        public void WriteText(string text)
        {
            text = text.Replace(@"#", @"\#");
            text = text.Replace(@"$", @"\$");
            text = text.Replace(@"%", @"\%");
            text = text.Replace(@"&", @"\&");
            text = text.Replace(@"\", @"\textbackslash");
            text = text.Replace(@"^", @"\textasciicircum");
            text = text.Replace(@"_", @"\_");
            text = text.Replace(@"{", @"\{");
            text = text.Replace(@"}", @"\}");
            text = text.Replace(@"~", @"\textasciitilde");

            Write(text);
        }

        public void WriteComment(string text)
        {
            Write("% " + text);
        }

        public void Write(string value)
        {
            _streamWriter.Write(value);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}
