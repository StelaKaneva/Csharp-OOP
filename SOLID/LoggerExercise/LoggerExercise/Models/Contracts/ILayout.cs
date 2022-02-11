using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Models.Contracts
{
    public interface ILayout
    {
        string Format { get; }
    }
}
