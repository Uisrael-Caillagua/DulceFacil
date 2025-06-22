using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RutaRepositorioImpl : RepositorioImpl<RUTA>, IRutaRepositorio
    {
        public RutaRepositorioImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
