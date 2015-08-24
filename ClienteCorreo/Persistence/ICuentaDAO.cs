using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Persistence
{
    /// <summary>
    /// Interfaz para la Cuenta.
    /// </summary>
    public interface ICuentaDAO
    {
        int create(CuentaDTO cuenta);

        CuentaDTO get(CuentaDTO cuenta);

        int update(CuentaDTO cuenta);

        List<CuentaDTO> list();

        int delete(CuentaDTO cuenta);

        int count(CuentaDTO cuenta);
    }
}
