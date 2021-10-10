using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    interface IUserRepository : IEntityRepository<User>
    {
    }
}
