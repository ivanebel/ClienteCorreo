using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Persistence
{
    /// <summary>
    /// Interfaz para el Servidor
    /// </summary>
    public interface IServerDAO
    {
        int save(ServerDTO server);

        ServerDTO get(ServerDTO server);

        List<ServerDTO> list();

        int update(ServerDTO server);

        int delete(ServerDTO server);

    }
}
