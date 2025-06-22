using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class VentaRepositorioImpl : RepositorioImpl<VENTA>, IVentaRepositorio
    {
        public VentaRepositorioImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
