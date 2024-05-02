using FlyYalla.DAL.Context;
using FlyYalla.DAL.Interfaces.IBaseRepository;
using FlyYalla.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.DAL.Repositories.BaseRepository
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BaseRepository<T> : IBaseRepository<T> /*IDisposable*/ where T : class
    {
        private readonly FlyYallaContext _context;
        private readonly DbSet<T> _dbSet;
        private bool _disposed = false;

        public BaseRepository(IUnitOfWork<FlyYallaContext> unitOfWork)
            : this(unitOfWork.Context)
        {
        }

        public BaseRepository(FlyYallaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Insert(T obj)
        {
            await _dbSet.AddAsync(obj);
        }

        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(T obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _dbSet.Attach(obj);
            }
            _dbSet.Remove(obj);
        }

        //public async Task SaveAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}

        // Implement IDisposable
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!_disposed)
        //    {
        //        if (disposing)
        //        {
        //            // Release managed resources
        //            _context.Dispose();
        //        }

        //        // Release unmanaged resources
        //        _disposed = true;
        //    }
        //}
    }

}
