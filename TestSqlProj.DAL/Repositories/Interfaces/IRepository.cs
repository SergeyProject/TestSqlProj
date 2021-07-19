using System.Collections.Generic;
using TestSqlProj.DAL.Models;

namespace TestSqlProj.DAL.Repositories.Interfaces
{
    public interface IRepository
    {
        void Create(User user);
        void Delete(int id);
        IEnumerable<User> GetAll();
        User FindById(int id);

    }
}
