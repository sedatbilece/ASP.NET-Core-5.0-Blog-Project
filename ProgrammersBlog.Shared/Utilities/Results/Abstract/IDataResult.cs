using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
   public  interface IDataResult<out T> : IResult //out : genus information will come from outside
    {

        public T Data { get;  }//new DataResult<Category>(ResultStatus.success , category ) ;
                               //new DataResult< IList<Category> >(ResultStatus.success , categorylist ) ;
    }
}
