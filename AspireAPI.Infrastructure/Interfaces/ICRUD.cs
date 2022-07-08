using AspireAPI.Domain.Models.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Infrastructure.Interfaces
{
  public interface ICRUD<T>
    where T : class
  {
    T Create(T entity);
    T Read();
    T Read(int id);
    T Update(T entity);
    T Delete(T entity);

    //Get all of Type T
    List<T> ReadAll();

  }
}
