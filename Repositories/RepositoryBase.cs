using ACEbets.Models;
using ACEbets.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ACEbets.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected BetService BettingContext { get; set; }

        public RepositoryBase(BetService bettingContext)
        {
            this.BettingContext = bettingContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.BettingContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.BettingContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.BettingContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.BettingContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.BettingContext.Set<T>().Remove(entity);
        }
    }
}