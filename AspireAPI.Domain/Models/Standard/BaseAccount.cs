using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.Models.Standard
{
  /// <summary>
  /// This is the base model for account information that will be inherited by any account type
  /// </summary>
  public class BaseAccount
  {
    #region ... Constructor ...
    public BaseAccount()
    {

    }
    #endregion

    #region ... Properties ...
    public int AccountID { get; set; }
    public string Email { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    #endregion
  }
}
