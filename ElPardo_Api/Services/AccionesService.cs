using ElPardo_Api.Common.Enums;
using ElPardo_Api.Contracts;
using ElPardo_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElPardo_Api.Services
{
    public class AccionesService : IAcciones
    {
        private readonly IMensaje _mensaje;

        public AccionesService(IMensaje mensaje)
        {
            _mensaje = mensaje;
        }

        public (string, string) JugarDeporteConBalon(Balon balon)
        {
            return (_mensaje.GetMensageDeporte(balon.TipoBalon), _mensaje.GetMensageMarcaBalon(balon.Marca));
        }
    }
}
