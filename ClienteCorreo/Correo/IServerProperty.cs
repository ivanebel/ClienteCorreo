using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Utils;

namespace ClienteCorreo.Correo
{
    interface IServerProperty
    {
        Property getPropiedadEnviar(ServerDTO server);
        Property getPropiedadRecibir(ServerDTO server);
    }
}
