using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void add(Brand brand);
        void update(Brand brand);
        void delete(Brand brand);
        List<Brand> GetAll();
    }
}
