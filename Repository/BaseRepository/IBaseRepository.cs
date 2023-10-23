using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string Id);
        Task<bool> Insert(T toInsert);
        Task<bool> Delete(string Id);
        Task<bool> Update(T toUpdate, string Id);
    }
}
