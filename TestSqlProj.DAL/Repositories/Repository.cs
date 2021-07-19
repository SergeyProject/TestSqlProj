using System.Collections.Generic;
using TestSqlProj.DAL.EF;
using TestSqlProj.DAL.Models;
using TestSqlProj.DAL.Repositories.Interfaces;

namespace TestSqlProj.DAL.Repositories
{
    public class Repository : IRepository
    {
        UserContext _userContext;

        public Repository(UserContext userContext)
        {
            _userContext = userContext;
        }
        public void Create(User user)
        {
            using(_userContext=new UserContext())
            {
                _userContext.Users.Add(user);
                _userContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (_userContext = new UserContext())
            {
                User user = _userContext.Users.Find(id);
                if (user != null)
                {
                    _userContext.Users.Remove(user);
                    _userContext.SaveChanges();
                }
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _userContext.Users;
        }

        public User FindById(int id)
        {
            User user = _userContext.Users.Find(id);
            if (user != null)
                return user;
            return null;
        }
    }
}
