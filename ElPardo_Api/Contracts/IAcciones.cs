using ElPardo_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElPardo_Api.Contracts
{
    public interface IAcciones
    {
        (string, string) JugarDeporteConBalon(Balon balon);
    }
}
