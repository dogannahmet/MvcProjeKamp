﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        Heading GetById(int id);
        void Add(Heading heading);
        void Update(Heading heading);
        void Delete(Heading heading);
    }
}
