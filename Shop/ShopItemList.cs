using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ShopItemsList<T> : IGetList, IEditable, IAdd<T> where T : ShopItem
    {
        private List<T> _shopItemList;

        private int _count = 0;

        public ShopItemsList()
        {
            _shopItemList = new List<T>();
        }


        public void Add(T shopItem)
        {
            _count++;
            shopItem.Id = _count;
            _shopItemList.Add(shopItem);
        }
        public void Edit()
        {

        }
        public void Remove()
        {

        }
        public void GetList()
        {
            foreach (T shopItem in _shopItemList)
            {
                shopItem.GetInfo();
            }
        }

        public ShopItem GetShopItem(int id)
        {
            ShopItem shopItem = new ShopItem();
            foreach (T item in _shopItemList)
            {
                if (id == item.Id)
                {
                    shopItem = item;
                    break;
                }
            }
            return shopItem;
        }

        public void ChangeShowcaseSize(int id, int size)
        {
            foreach (T item in _shopItemList)
            {
                if (id == item.Id)
                {
                    item.Size = item.Size - size;
                    break;
                }
            }
        }
        public int GetCount()
        {
            return _count;
        }

    }
}
