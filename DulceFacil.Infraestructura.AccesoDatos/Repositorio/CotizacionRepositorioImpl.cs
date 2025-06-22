using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class CotizacionRepositorioImpl : RepositorioImpl<COTIZACION>, ICotizacionRepositorio
    {
        public CotizacionRepositorioImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
