using System;
using ManhattanProject.Models.Entities;
using ManhattanProject.Services.Interfaces;
using ManhattanProject.Repositories.Interfaces;

namespace ManhattanProject.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }
    }
}
