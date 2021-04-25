using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    //Yanlış kullanım (bkz => IRepository)
    public interface ICategoryDal : IRepository<Category>
    {
       
    }
}
