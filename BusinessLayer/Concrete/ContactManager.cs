using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }
        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
        public Contact GetById(int id)
        {
            return _contactDal.Get(c => c.ConcactId == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }

        
    }
}
