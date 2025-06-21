using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LaTeX
{
    /// <summary>
    /// A class that provides methods for writing LaTeX to a stream. This class provides both low-level methods - such as writing the exact LaTeX that should appear in the file without any interference - and high-level methods - such as writing out the full document from a hierarchical structure of commands. This is necessary because LaTeX has a very inconsistent syntax - particularly when LaTeX packages are considered - and sometimes it is necessary to write some LaTeX literally without much help from a library such as this one.
    /// </summary>
    public class LaTeXWriter : IDisposable
    {
        /// <summary>
        /// The underlying stream writer object.
        /// </summary>
        protected StreamWriter _streamWriter;

        /// <summary>
        /// Creates a new instance of LaTeXWriter for writing LaTeX to a file.
        /// </summary>
        /// <param name="filePath"></param>
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
            command.Write(this);
        }

        public void WriteTableRow(bool isLastRow = false, params string[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                var datum = data[i];

                if (i > 0)
                {
                    Write(" & ");
                }

                Write(datum.Replace(@"&", @"\&"));
            }

            if (!isLastRow)
            {
                Write(" \\\\");
            }

            Write(" \n");
        }

        /// <summary>
        /// Replaces all reserved characters in the given string with their escaped values. Useful when writing text to a LaTeX stream.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EscapeText(string text)
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

            return text;
        }

        public void WriteText(string text)
        {
            text = EscapeText(text);

            Write(text);
        }

        public void WriteCommentLine(string text)
        {
            WriteLine("% " + text);
        }

        public void WriteComment(string text)
        {
            Write("% " + text);
        }

        /// <summary>
        /// Writes the given string to the stream without modifying it, and starts a new line.
        /// </summary>
        /// <param name="value"></param>
        public void WriteLine(string value = "")
        {
            if (value.Trim() == "")
            {
                Write("\n");
            }
            else
            {
                Write(value + " \n");
            }
        }

        /// <summary>
        /// Writes the given string to the stream without modifying it in any way. Useful for writing literal LaTeX to the stream.
        /// </summary>
        /// <param name="value"></param>
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
