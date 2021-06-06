using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message message)
        {
            _messageDal.Insert(message);
        }

        public void Delete(Message message)
        {
            throw new System.NotImplementedException();
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(m => m.MessageId == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(m => m.Receiver == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messageDal.List(m => m.Sender == "admin@gmail.com");
        }

        public void Update(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}
