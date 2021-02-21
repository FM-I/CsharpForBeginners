using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    interface IAdd<T>
    {
        public void Add(T shopItem);
    }
}
