using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Models.Contracts
{
    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }

        void Log(IError error);
    }
}
