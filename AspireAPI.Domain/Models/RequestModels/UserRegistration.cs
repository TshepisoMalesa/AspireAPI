using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.Models.RequestModels
{
  /// <summary>
  /// Model that will store all the infomation that comes from the aspire react native front-end
  /// </summary>
  public class UserRegistration
  {
    #region ...Constructor ...
    public UserRegistration()
    {

    }

    #endregion

    #region ...Properties ...
    public AspireAPI.Domain.DAL.User user { get; set; } = new AspireAPI.Domain.DAL.User();
    public AspireAPI.Domain.DAL.Account account { get; set; } = new AspireAPI.Domain.DAL.Account();
    public AspireAPI.Domain.DAL.Address address { get; set; } = new AspireAPI.Domain.DAL.Address();
    public AspireAPI.Domain.DAL.UserSecurity security { get; set; } = new AspireAPI.Domain.DAL.UserSecurity();
    #endregion
  }
}
