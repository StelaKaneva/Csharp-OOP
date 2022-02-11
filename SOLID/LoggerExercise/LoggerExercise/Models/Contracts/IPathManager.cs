using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Models.Contracts
{
    public interface IPathManager
    {
        //bin/debug
        string CurrentDirectoryPath { get;}

        //bin/debug/log.txt
        string CurrentFilePath { get; }

        string GetCurrentPath();

        void EnsureDirectoryAndFileExists();
    }
}
