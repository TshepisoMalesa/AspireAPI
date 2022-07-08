using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.DAL
{
  public class UserSecurity
  {
    public int ID { get; set; }
    public string Token { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    public int UserID { get; set; }
  }
}
