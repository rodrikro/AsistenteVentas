﻿using Negocio.Servicios.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class MainNegocioServicios
    {
        public UsuarioServicios ServicioUsuarios { get; set; }

        public MainNegocioServicios() 
        {
            ServicioUsuarios = new UsuarioServicios();
        }
    }
}
