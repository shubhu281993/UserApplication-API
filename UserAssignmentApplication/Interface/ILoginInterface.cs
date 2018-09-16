using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAssignmentApplication.Model;

namespace UserAssignmentApplication.Interface
{
    public interface ILoginInterface
    {
        Task Create(User user);
        Task GetUser(User user);
    }
}
