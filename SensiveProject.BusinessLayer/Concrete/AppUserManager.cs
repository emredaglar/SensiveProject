using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserService _appUserService;

        public AppUserManager(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public void TDelete(int id)
        {
           _appUserService.TDelete(id);
           
        }

        public List<AppUser> TGetAll()
        {
           return _appUserService.TGetAll();
        }

        public AppUser TGetById(int id)
        {
            return _appUserService.TGetById(id);
        }

        public void TInsert(AppUser entity)
        {
            _appUserService.TInsert(entity);
        }

        public void TUpdate(AppUser entity)
        {
            _appUserService.TUpdate(entity);
        }
    }
}
