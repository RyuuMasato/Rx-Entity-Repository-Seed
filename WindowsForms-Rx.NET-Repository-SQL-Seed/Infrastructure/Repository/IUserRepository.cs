using RxRepoSeed.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxRepoSeed.Infrastructure.Repository
{
    interface IUserRepository : IRepository<User, string>
    {
        IEnumerable<User> Find(string qeury);
        IEnumerable<User> FindAll();
    }
}
