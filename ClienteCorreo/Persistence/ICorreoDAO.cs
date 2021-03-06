﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Persistence
{
    public interface ICorreoDAO
    {
        int create(CorreoDTO correo);

        CorreoDTO get(CorreoDTO correo);

        int update(CorreoDTO correo);

        int markAsRead(CorreoDTO correo, bool leido);

        List<CorreoDTO> list(bool read, bool sent, int cant, CuentaDTO cuenta = null);

        int delete(CorreoDTO correo);

        DateTime lastMail(CuentaDTO cuenta);

        int clear(CuentaDTO cuenta);

        int LastId(CuentaDTO cuenta);

        int mailCount(CuentaDTO cuenta);


    }
}
