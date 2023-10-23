using Data;
using Data.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext _context;
        protected DbSet<T> _entities;
        public BaseRepository(DataContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task<bool> Delete(string Id)
        {
            T? toDelete = await _entities.SingleOrDefaultAsync(x => x.Id == Id);
            await Task.Run(() => _entities.Remove(toDelete));
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(string Id)
        {
            return await _entities.SingleOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<bool> Insert(T toInsert)
        {
            await _entities.AddAsync(toInsert);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(T toUpdate, string Id)
        {
            T? tmp = await _entities.SingleOrDefaultAsync(x => x.Id == Id);
            await Task.Run(() => _context.Entry(tmp).CurrentValues.SetValues(toUpdate));
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
