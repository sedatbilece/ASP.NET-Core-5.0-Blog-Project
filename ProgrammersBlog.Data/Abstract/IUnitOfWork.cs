using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
   public  interface IUnitOfWork :IAsyncDisposable
    {

        IArticleRepository Articles { get; } // _unitofwork.Articles
        ICategoryRepository Categories { get; } //_unitofwork.Categories.AddAsync(....);
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository User { get; }

        Task<int> SaveAsync();




    }
}
