using ManhattanProject.Repositories.Contexts;
using ManhattanProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManhattanProject.Models.Entities;

namespace ManhattanProject.Repositories
{
    public class UserRepository: IUserRepository
    {
        private UserContext _userContext;

        public UserRepository()
        {
            _userContext = new UserContext();
        }

        public User GetUserByEmail(string email)
        {
            return _userContext.Users.Where(x => x.Email == email).FirstOrDefault();
        }
    }
}
