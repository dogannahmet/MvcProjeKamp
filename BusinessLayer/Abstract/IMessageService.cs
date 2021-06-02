using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void Add(Message message);
        Message GetById(int id);
        void Delete(Message message);
        void Update(Message message);
    }
}
