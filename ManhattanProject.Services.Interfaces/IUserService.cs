using ManhattanProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManhattanProject.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserByEmail(string email);

    }
}
