using ManhattanProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManhattanProject.Models.Entities;

namespace ManhattanProject.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        public User GetUserByEmail(string email)
        {
            return new User() { Login = "test_login", Name = "test name"};
        }
    }
}
