using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void add(Color color);
        void update(Color color);
        void delete(Color color);
        List<Color> GetAll();
    }
}
