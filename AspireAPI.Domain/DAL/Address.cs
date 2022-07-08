using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.DAL
{
  public class Address
  {
    public int LocationID { get; set; } = 0;
    public string Country { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public int AreaCode { get; set; }
    public int UID { get; set; }
  }
}
