using ElPardo_Api.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElPardo_Api.Contracts
{
    public interface IMensaje
    {
        string GetMensageDeporte(TipoBalon balon);
        string GetMensageMarcaBalon(string marca);
    }
}
