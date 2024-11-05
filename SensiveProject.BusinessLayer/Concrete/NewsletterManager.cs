﻿using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
	public class NewsletterManager : INewsletterService
	{
		private readonly INewsletterDal _newsletterDal;

		public NewsletterManager(INewsletterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}

		public void TDelete(int id)
		{
			_newsletterDal.Delete(id);
		}

		public List<Newsletter> TGetAll()
		{
			return _newsletterDal.GetAll();
		}

		public Newsletter TGetById(int id)
		{
			return _newsletterDal.GetById(id);
		}

		public void TInsert(Newsletter entity)
		{
			_newsletterDal.Insert(entity);
		}

		public void TUpdate(Newsletter entity)
		{
			_newsletterDal.Update(entity);	
		}
	}
}
