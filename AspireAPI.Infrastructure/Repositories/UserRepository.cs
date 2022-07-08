using AspireAPI.Domain.DAL;
using AspireAPI.Domain.DAL.DatabaseContext;
using AspireAPI.Domain.Models.RequestModels;
using AspireAPI.Domain.Models.Standard;
using AspireAPI.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Infrastructure.Repositories
{
  public class UserRepository : ICRUD<User>
  {
    AspireDBContext _ctx = new AspireDBContext();

    public User Create(User entity)
    {
      _ctx.User.Add(entity);
      _ctx.SaveChanges();
      entity = _ctx.User.Where(x => x.Firstname == entity.Firstname && x.Lastname == entity.Lastname && x.Middlename == entity.Middlename && x.DateAdded == entity.DateAdded).FirstOrDefault();
      return entity;
    }

    public User Delete(User entity)
    {
      throw new NotImplementedException();
    }

    public User Read()
    {
      throw new NotImplementedException();
    }
    public User? Read(int id)
    {
      return _ctx.User.Where(x => x.UserID == id).FirstOrDefault();
    }

    public List<User> ReadAll()
    {
      return  _ctx.User.ToList();
    }

    public User Update(User entity)
    {
      throw new NotImplementedException();
    }

    public UserRegistration Register(UserRegistration entity)
    {
     
      entity.account.UID = entity.user.UserID;
      entity.security.UserID = entity.user.UserID;
      entity.address.UID = entity.user.UserID;

      _ctx.Account.Add(entity.account);
      _ctx.UserSecurity.Add(entity.security);
      _ctx.Address.Add(entity.address);
      _ctx.SaveChanges();

      return entity;
    }

  }
}
