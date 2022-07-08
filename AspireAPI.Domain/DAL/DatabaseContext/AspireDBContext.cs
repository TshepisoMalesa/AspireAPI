using Aspire.Security.Secrets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireAPI.Domain.DAL.DatabaseContext
{
  public class AspireDBContext:DbContext
  {
    public static DbContextOptionsBuilder options = new DbContextOptionsBuilder();
    public AspireDBContext()
     : base(options.UseSqlServer(Keys.ConnectionString).Options)
    {

    }

    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<Account> Account { get; set; }
    public virtual DbSet<UserSecurity> UserSecurity { get; set; }
    public virtual DbSet<Address> Address { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("MANAGE");
    }

  }
}
