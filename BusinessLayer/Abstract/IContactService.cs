using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        Contact GetById(int id);
        void Add(Contact contact);
        void Delete(Contact contact);
        void Update(Contact contact);
    }
}
