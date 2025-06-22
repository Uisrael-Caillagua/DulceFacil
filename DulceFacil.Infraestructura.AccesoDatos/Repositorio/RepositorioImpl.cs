using DulceFacil.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly DulceFacilContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositorioImpl(DulceFacilContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
         
        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            { 
                throw new Exception("Error: no se pudo insertar datos" + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entidad = await GetByIdAsync(id);
                _dbSet.Remove(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: no se pudo eliminar datos" + ex.Message);
            }

        }

        public async Task<IEnumerable<T>> GetAllsync()
        {
            try
            {
                return await _dbSet.ToListAsync();         
            }
            catch (Exception ex)
            {
                throw new Exception("Error: no se pudo listar datos" + ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: no se encontro el ID de datos" + ex.Message);
            }
        }

        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: no se pudo Actualizar datos" + ex.Message);
            }
        }
    }

}
