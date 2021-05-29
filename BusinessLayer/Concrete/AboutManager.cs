using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            _aboutDal.Insert(about);
        }

        public void Delete(About about)
        {
            _aboutDal.Delete(about);
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
        public About GetById(int id)
        {
            return _aboutDal.Get(a => a.AboutId == id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }

        
    }
}
