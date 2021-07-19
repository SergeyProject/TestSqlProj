using System.Data.Entity;
using TestSqlProj.DAL.Models;
using TestSqlProj.DAL.Settings;

namespace TestSqlProj.DAL.EF
{
    public class UserContext:DbContext
    {
        public UserContext() : base(ConnectSetting.ConnectionString)
        { }

        public DbSet<User> Users { get; set; }
    }
}
