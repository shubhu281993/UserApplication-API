using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAssignmentApplication.DBModel;

namespace UserAssignmentApplication.Repository
{
    public class AssignmentRepository 
    {
        private readonly ObjectContext context = null;

        public AssignmentRepository(IOptions<Settings> settings)
        {

        }
    }
}
