using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data// !! dependecies need ef core  (nuget manager) 
{
   public  interface IEntityRepository <T> where  T:class,IEntity,new()//this is for the entities interface implementation
        // T is sub repos type like that "user" ,"comment " ,"category"
    {
        // get the object 
        Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T, object>>[] includeProperties   );// var user= repository.GetAsync(k=>k.id==15)
        //   expressin is a type t object and predicate its name , params mean more than one parameters for t object other properties

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);
        // if you dont give the parameter predicate is null and the function get all


        Task AddAsync(T entity);// add method

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);// this is a control for existing

        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}
