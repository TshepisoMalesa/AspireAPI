using AspireAPI.Domain.DAL;
using AspireAPI.Domain.DAL.DatabaseContext;
using AspireAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Infrastructure.Repositories
{
  public class AccountRepository : ICRUD<Account>
  {
    AspireDBContext _ctx = new AspireDBContext();
    public Account Create(Account entity)
    {
      _ctx.Account.Add(entity);
      _ctx.SaveChanges();
      entity = _ctx.Account.Last();
      return entity;
    }

    public Account Delete(Account entity)
    {
      throw new NotImplementedException();
    }

    public Account Read()
    {
      throw new NotImplementedException();
    }

    public Account Read(int id)
    {
      throw new NotImplementedException();
    }

    public List<Account> ReadAll()
    {
      throw new NotImplementedException();
    }

    public Account Update(Account entity)
    {
      throw new NotImplementedException();
    }
  }
}
