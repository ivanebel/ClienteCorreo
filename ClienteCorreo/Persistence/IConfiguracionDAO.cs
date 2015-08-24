using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Persistence
{
    /// <summary>
    /// Interfaz de la Configuración
    /// </summary>
    public interface IConfiguracionDAO
    {

        void modificarConfiguracion(ConfiguracionDTO config);

        ConfiguracionDTO getConfiguracion();
    }
}
