﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoAplicacion.Entities
{
    public class Cliente
    {
        public int ID_CLIENTE { get; set; }
        public string CEDULA_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string CORREO { get; set; }
        public string TELEFONO { get; set; }
        public DateTime FECHA { get; set; }
        public int ID_COMPRA { get; set; }

    }
}