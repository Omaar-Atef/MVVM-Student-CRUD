using MVVM_D2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_D2.DataService
{
    public interface IDataService<T>
    {
        IEnumerable<T> GetAll();

        void Delete(int id);

        void Update(T entity);

        void Add(T entity);
    }
}
