using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.Models.Standard
{
  /// <summary>
  /// This is the standard or base user model that all user types will inherit from
  /// </summary>
  public class BaseUser
  {
    #region ... Constructor ...
    public BaseUser()
    {

    }
    #endregion

    #region ... Properties ...
    public int UserID { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string? Middlename { get; set; }
    public string Lastname { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; }
    #endregion

  }
}
