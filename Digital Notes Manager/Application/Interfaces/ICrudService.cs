using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Interfaces
{
    public interface ICrudService<T>
    {
        Task AddAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(int itemId);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
