﻿using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class InventarioRepositorioImpl : RepositorioImpl<INVENTARIO>, IInventarioRepositorio

    {
        public InventarioRepositorioImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
