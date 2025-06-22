using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class Cotizacion_DetalleRepositorioImpl : RepositorioImpl<COTIZACION_DETALLE>, ICotizacion_DetalleRepositorio
    {
        public Cotizacion_DetalleRepositorioImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
