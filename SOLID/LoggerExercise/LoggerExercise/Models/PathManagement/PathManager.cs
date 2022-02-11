using LoggerExercise.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggerExercise.Models.PathManagement
{
    public class PathManager : IPathManager
    {
        //private const string PATH_DELIMETER = "\\";

        private readonly string currentPath;
        private readonly string folderName;
        private readonly string fileName;

        //They should pass folder name and file name
        public PathManager(string folderName, string fileName) : this ()
        {
            this.folderName = folderName;
            this.fileName = fileName;
        }

        //Tells me the path where my app is running on user PC
        private PathManager()
        {
            this.currentPath = this.GetCurrentPath();
        }

        public string CurrentDirectoryPath => Path.Combine(this.currentPath, this.folderName);

        public string CurrentFilePath => Path.Combine(this.CurrentDirectoryPath, this.fileName);

        public void EnsureDirectoryAndFileExists()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath))
            {
                Directory.CreateDirectory(this.CurrentDirectoryPath);
            }

            File.AppendAllText(this.CurrentFilePath, String.Empty);
            //File already exists - open file, write empty string, close file.
            //File not exists - create file, write empty string, close file.
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
