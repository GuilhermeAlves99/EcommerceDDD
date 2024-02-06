using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Generics
{
    public class RepositoryGenerics<T> : IGenerics<T>, IDisposable where T : class
    {
        //criando um objeto readonly para ler o dbContext
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryGenerics() 
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();  
        }

        public async Task Add(T Object)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(Object);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T Object)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                data.Set<T>().Remove(Object);
                await data.SaveChangesAsync();
            }
        }

        

        public async Task<T> GetEntityById(int Id)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
               return await data.Set<T>().FindAsync(Id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                //usando AsNoTracking para que o contexto não seja marcado.
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task Update(T Object)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                data.Set<T>().Update(Object);
                await data.SaveChangesAsync();
            }
        }

        #region Dispose

        bool _disposed = false;

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                handle.Dispose();
            }

            _disposed = true;
        }
        #endregion
    }
}
