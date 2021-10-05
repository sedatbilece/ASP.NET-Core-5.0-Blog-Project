using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
   public abstract class EntityBase//  ** our class is a abstract class , here so abstract uses **
    {
        public virtual int Id { get; set; } // ** and the objects can be override , virtual because of this **
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;

        public virtual bool IsDeleted { get; set; } = false;

        public virtual bool IsActive{ get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual string ModifiedByName { get; set; } = "Admin";

        public virtual string Note { get; set; } 
    }
}
