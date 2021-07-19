using System.Collections.Generic;
using TestSqlProj.BLL.DTO;

namespace TestSqlProj.BLL.Interfaces
{
    public interface IServiceDTO
    {
        void Add(UserDTO user);
        IEnumerable<UserDTO> GetAll();

    }
}
