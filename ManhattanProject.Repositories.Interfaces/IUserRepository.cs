using ManhattanProject.Models.Entities;

namespace ManhattanProject.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
    }
}
