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

        public string GetCommandName(LaTeXCommand command)
        {
            var commandNameAttribute = command.GetType().GetCustomAttributes(typeof(LaTeXCommandNameAttribute), true)[0] as LaTeXCommandNameAttribute;

            return commandNameAttribute.Name;
        }

        public void WriteCommand(string name)
        {
            Write("\\" + name);
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
            }
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
