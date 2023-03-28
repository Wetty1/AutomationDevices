using AutomationDevices.Core.Domain.Base;
using AutomationDevices.Database.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDevices.Database.Repositories.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AutomationDevicesContext _context;
        public DbSet<T> _dbSet { get; set; }
        public BaseRepository()
        {
            _context = new AutomationDevicesContext();
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T obj)
        {
            _dbSet.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T obj)
        {
            _dbSet.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T obj)
        {
            _dbSet.Update(obj);
            await _context.SaveChangesAsync();
        }
    }
}
