using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAssignmentApplication.DBModel;
using UserAssignmentApplication.Interface;
using UserAssignmentApplication.Model;

namespace UserAssignmentApplication.Repository
{
    public class LoginRepository : ILoginInterface
    {
        private readonly ObjectContext _context = null;

        public LoginRepository(IOptions<Settings> settings)
        {
            _context = new ObjectContext(settings);
        }

        public async Task Create(User user)
        {
            await _context.Users.InsertOneAsync(user);
        }

        public async Task GetUser(User user)
        {
            try
            {
                await _context.Users.Find(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
