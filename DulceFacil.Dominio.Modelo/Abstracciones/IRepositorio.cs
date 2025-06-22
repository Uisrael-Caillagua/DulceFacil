using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelo.Abstracciones
{
    public interface IRepositorio <T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllsync();
        Task AddAsync(T entidad);
        Task UpdateAsync(T entidad);
        Task DeleteAsync(int id);
    }
}
