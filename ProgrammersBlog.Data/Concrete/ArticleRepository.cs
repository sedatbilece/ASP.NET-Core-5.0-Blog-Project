﻿using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete
{
    public class ArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext context) : base(context)
        {//cons is for getting the ef base all method in here

        }



    }
}
