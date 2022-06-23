using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.DataServices
{
    public interface IDataService<T>
    {
        List<T> GetAll();
        T Get(int id);
        bool Create(T entity);
        bool Delete(int id);
        bool Update(int id, T entity);
    }
}
