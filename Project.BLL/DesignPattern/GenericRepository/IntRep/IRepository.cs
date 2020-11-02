using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.GenericRepository.IntRep
{
    public interface IRepository IRepository<T> where T:BaseEntity
    {
        //List Methods
        
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetUpdates();
        
        List<T> GetAll();

        //Command Methods
        void Add(T item);

        void Delete(T item);

        void Update(T item);

        void Destroy(int id);
        void AddRange(List<T> item);

        //Linq Expressions Methods
        List<T> Where(Expression<Func<T, bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        T GetDefault(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, bool>> exp);

        //Find Method
        T Find(int id);
    }
}
