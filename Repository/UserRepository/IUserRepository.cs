using Data.Entity;
using Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
