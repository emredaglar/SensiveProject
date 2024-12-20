﻿using Microsoft.EntityFrameworkCore;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.DataAccessLayer.Context;
using SensiveProject.DataAccessLayer.Repositories;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.EntityFreamwork
{
	public class EfCommentDal : GenericRepository<Comment>, ICommentDal
	{
		public EfCommentDal(SensiveContext context) : base(context)
		{
		}
        
        public List<Comment> GetCommentsByAricleId(int id)
        { 
            var context=new SensiveContext();
            var values=context.Comments.Where(x=>x.ArticleId==id).Include(y=>y.Article).Include(z=>z.AppUser).ToList(); 
            return values;
        }
    }
}
