using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class Ubicacion_EntregaRepositorioImpl : RepositorioImpl<UBICACION_ENTREGA>, IUbicacion_EntregaRepositorio
    {
        public Ubicacion_EntregaRepositorioImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
