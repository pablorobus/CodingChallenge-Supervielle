using CodingChallenge.Entities.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Interfaces
{
    public interface IFormas
    {
        int Tipo { get; }

        bool Es(IFormas forma);

        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
