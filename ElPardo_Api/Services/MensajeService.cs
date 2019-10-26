using ElPardo_Api.Common.Enums;
using ElPardo_Api.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElPardo_Api.Services
{
    public class MensajeService : IMensaje
    {
        public string GetMensageDeporte(TipoBalon balon) =>
            $"El deporte que estás jugando es {balon}.";

        public string GetMensageMarcaBalon(string marca) =>
            $"La marca del balón es: {marca}.";
    }
}
