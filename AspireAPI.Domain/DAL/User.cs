using AspireAPI.Domain.Models.Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.DAL
{
  /// <summary>
  /// This is the general user model that inherits BaseUser model
  /// </summary>
  /// 

  public class User : BaseUser
  {
    #region ... Constructor ...
    public User()
    {

    }
    #endregion

    #region ... Properties ...
    public int Role { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    #endregion

  }
}
