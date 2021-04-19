using System.Collections.Generic;
namespace Series.interfaces
{
    public interface IRepository<T>
    {
        List<T> List();

        T FindById(int id);

        void Add(T entity);

        void Delete(int id);

        void Update(int id, T entity);

        int NextId();
         
    }
}