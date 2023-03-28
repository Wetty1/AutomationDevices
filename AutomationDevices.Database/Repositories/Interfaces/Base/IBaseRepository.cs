using AutomationDevices.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDevices.Database.Repositories.Interfaces.Base
{
    public interface IBaseRepository<T>: IDisposable where T : BaseEntity
    {
        Task AddAsync(T obj);
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task UpdateAsync(T obj);
        Task DeleteAsync(T obj);
    }
}
