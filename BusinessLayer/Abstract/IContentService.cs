using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListById(int id);
        void Add(Content content);
        Content GetById(int id);
        void Delete(Content content);
        void Update(Content content);
    }
}
