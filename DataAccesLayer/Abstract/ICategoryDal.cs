using EntityLayer.Concrete;

namespace DataAccesLayer.Abstract
{
    //Yanlış kullanım (bkz => IRepository)
    public interface ICategoryDal : IRepository<Category>
    {
       
    }
}
