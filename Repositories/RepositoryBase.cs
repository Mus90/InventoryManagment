using InventoryManagement.Data;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Repositories
{
    public class RepositoryBase<T> where T : class
    {
        protected ApplicationDbContext context { get; set; }
        public RepositoryBase(ApplicationDbContext appContext)
        {
            context = appContext;
        }
        public IQueryable<T> FindAll()
        {
            return context.Set<T>();
        }

        public T Find(int? Id)
        {
            return context.Set<T>().Find(Id);
        }

        public T Find(string Id)
        {
            return context.Set<T>().Find(Id);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }

        public async Task<ActionResponseDto> CreateAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            try
            {
                await context.SaveChangesAsync();
                return new ActionResponseDto()
                {
                    Success = true,
                    result = entity
                };
            }
            catch (Exception e)
            {
                return new ActionResponseDto()
                {
                    Success = false,
                    message = e.ToString(),
                    result = entity
                };
            }
        }

        public async Task CreateAndSaveRangeAsync(ICollection<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }
        public async Task CreateRangeAsync(ICollection<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
        }

        public async Task<ActionResponseDto> UpdateAsync(T entity)
        {
            try
            {
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return new ActionResponseDto()
                {
                    Success = true,
                    result = entity
                };
            }
            catch (Exception e)
            {
                return new ActionResponseDto()
                {
                    Success = false,
                    message = e.ToString(),
                    result = entity
                };
            }

        }


        public async Task<ActionResponseDto> RemoveAsync(T entity)
        {
            try
            {
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return new ActionResponseDto()
                {
                    Success = true,
                    result = entity
                };
            }
            catch (Exception e)
            {
                return new ActionResponseDto()
                {
                    Success = false,
                    message = e.ToString(),
                    result = entity
                };
            }

        }

    }
}
