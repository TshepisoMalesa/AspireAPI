using AspireAPI.Domain.Models.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.DAL
{
  public class Account : BaseAccount
  {
    public string UANumber { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public int UID { get; set; }
  }
}
