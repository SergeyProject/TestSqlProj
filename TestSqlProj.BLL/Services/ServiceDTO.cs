using System.Collections.Generic;
using TestSqlProj.BLL.DTO;
using TestSqlProj.DAL.EF;
using TestSqlProj.BLL.Mappers;
using TestSqlProj.DAL.Repositories.Interfaces;
using TestSqlProj.DAL.Repositories;
using TestSqlProj.BLL.Interfaces;
using TestSqlProj.DAL.Models;

namespace TestSqlProj.BLL.Services
{
    public  class ServiceDTO //: IServiceDTO
    {        
        IRepository _repository;
        public ServiceDTO(IRepository repository)
        {
            _repository = repository;
        }
        public ServiceDTO() {
            UserContext userContext = new UserContext();
            _repository = new Repository(userContext);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(UserDTO user)
        {
            _repository.Create(user.toUser());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

       public User FindId(int id)
        {
           return _repository.FindById(id);
        }
       
    }
}
