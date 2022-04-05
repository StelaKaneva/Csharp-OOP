using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterfacePattern
{
    public interface ICarBuilder
    {
        ICarBuilder BuildTyres(Car car);

        ICarBuilder BuildEngine(Car car);

        ICarBuilder BuildTransmission(Car car);

    }
}
