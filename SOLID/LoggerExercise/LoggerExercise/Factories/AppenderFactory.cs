using LoggerExercise.Common;
using LoggerExercise.Models.Appenders;
using LoggerExercise.Models.Contracts;
using LoggerExercise.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Factories
{
    public class AppenderFactory
    {
        public AppenderFactory()
        {

        }

        public IAppender CreateAppender(string appenderType, ILayout layout, Level level, IFile file = null)
        {
            IAppender appender;

            if (appenderType == "ConsoleAppender")
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if (appenderType == "FileAppender" && file != null)
            {
                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new InvalidOperationException(GlobalConstants.InvalidAppenderType);
            }

            return appender;
        }
    }
}
