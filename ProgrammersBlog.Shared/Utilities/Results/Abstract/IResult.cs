using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        // this is in the complex type folder type is a enum 
        public ResultStatus ResultStatus { get;  }//ResultStatus.success // ResultStatus.error like that 
        public String Message { get;  }
        public Exception Exception { get;  }
    }
}
