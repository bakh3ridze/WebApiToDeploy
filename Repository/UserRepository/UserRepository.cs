using Data;
using Data.Entity;
using Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}
