﻿using SensiveProject.DataAccessLayer.Abstract;
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
	public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EFCategoryDal(SensiveContext context) : base(context)
		{
		}
	}
}
