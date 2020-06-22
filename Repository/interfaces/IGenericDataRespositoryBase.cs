using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.interfaces
{
   public interface IGenericDataRespositoryBase<T, KeyT>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetAsync(KeyT id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task CreateAsync(T entity);

        Task InsertEntity(T entity);

        Task SaverChangeAsyc();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task AddRangeAsync(IEnumerable<T> entities);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="changedDataObject"></param>
        Task UpdateAsync(T changedDataObject);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task DeleteAsync(KeyT id);

        Task<T> FindAsync(Expression<Func<T, bool>> match);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match);
    }
}
