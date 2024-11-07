using Microsoft.EntityFrameworkCore;
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
	public class EfArticleDal : GenericRepository<Article>, IArticleDal
	{
		public EfArticleDal(SensiveContext context) : base(context)
		{
		}

        public List<Article> ArticleListWithCategory()
        {
            var context = new SensiveContext();
            var values=context.Articles.Include(x=>x.category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new SensiveContext();
            var values = context.Articles.Include(x => x.category).Include(y=>y.AppUser).ToList();
            return values;
        }
    }
}
