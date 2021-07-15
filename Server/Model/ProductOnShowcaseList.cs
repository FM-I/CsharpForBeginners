using System.Collections.Generic;

namespace Shop
{
    class ProductOnShowcaseList : IPlaseProduct, IGetList<ProductsOnShowcase>
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
        public List<ProductsOnShowcase> GetList()
        {
            foreach (ProductsOnShowcase productsOnShowcase in _productsOnShowcases)
            {
                productsOnShowcase.GetInfo();
            }

            return null;
        }
        public int GetCount()
        {
            return _count;
        }
    }
}
