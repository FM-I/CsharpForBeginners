using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ProductOnShowcaseList : IPlaseProduct, IGetList
    {
        private List<ProductsOnShowcase> _productsOnShowcases;
        private int _count = 0;

        public ProductOnShowcaseList()
        {
            _productsOnShowcases = new List<ProductsOnShowcase>();
        }

        public void PlaceProduct(ProductsOnShowcase productsOnShowcase)
        {
            _count++;
            productsOnShowcase.Id = _count;
            _productsOnShowcases.Add(productsOnShowcase);
        }
        public void GetList()
        {
            foreach (ProductsOnShowcase productsOnShowcase in _productsOnShowcases)
            {
                productsOnShowcase.GetInfo();
            }
        }
        public int GetCount()
        {
            return _count;
        }
    }
}
