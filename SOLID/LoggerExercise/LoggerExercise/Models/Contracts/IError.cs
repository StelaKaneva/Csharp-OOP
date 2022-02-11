using LoggerExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        Level Level { get; }
    }
}
