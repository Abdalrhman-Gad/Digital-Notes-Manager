using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Interfaces
{
    public interface ICrudService<TAdd>
    {
        Task<bool> UpdateAsync(TAdd item);

        Task<bool> DeleteAsync(int itemId);
    }
}
