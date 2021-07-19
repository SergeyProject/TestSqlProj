using TestSqlProj.BLL.DTO;
using TestSqlProj.DAL.Models;

namespace TestSqlProj.BLL.Mappers
{
    public static class Mapper
    {
        public static User toUser(this UserDTO user)
        {
            return new User
            {
                Name = user.Name,
                Age = user.Age
            };
        }
    }
}
