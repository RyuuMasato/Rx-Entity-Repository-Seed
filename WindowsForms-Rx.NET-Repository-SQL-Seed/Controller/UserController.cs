using RxRepoSeed.Infrastructure.Context;
using RxRepoSeed.Infrastructure.Repository;
using RxRepoSeed.Infrastructure.UnitOfWork;
using RxRepoSeed.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxRepoSeed.Controller
{
    public class UserController
    {
        private readonly UserContext _userContext;
        private readonly UnitOfWork _unitOfWork;
        private readonly UserRepository _userRepository; 

        public UserController()
        {
            _userContext = new UserContext();
            _userRepository = new UserRepository(_userContext);
            _unitOfWork = new UnitOfWork(_userContext);
        }

        public void Create(string username)
        {
            _userRepository.Create(new User() { Username = username });
            _unitOfWork.SaveChanges();
        }

        public User FindByUsername(string username)
        {
            return _userRepository.Find(username).First();
        }

        public IEnumerable<User> UpdateUserList()
        {
            return _userRepository.FindAll();
        }
    }
}
