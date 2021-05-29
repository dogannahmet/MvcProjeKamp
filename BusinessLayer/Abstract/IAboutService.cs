using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void Add(About about);
        About GetById(int id);
        void Delete(About about);
        void Update(About about);
    }
}
