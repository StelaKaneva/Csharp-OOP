using LoggerExercise.IOManagement.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggerExercise.IOManagement
{
    public class FileWriter : IWriter
    {
        public FileWriter(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath{ get; }

        public void Write(string text)
        {
            File.WriteAllText(this.FilePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(this.FilePath, text + Environment.NewLine);
        }
    }
}

