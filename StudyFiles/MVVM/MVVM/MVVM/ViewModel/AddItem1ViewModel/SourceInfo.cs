using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    partial class AddItem1ViewModel
    {
        #region ChoiceList
        private ObservableCollection<ItemType.ShopTypes> _ChoiceList = new ObservableCollection<ItemType.ShopTypes>
        {
            ItemType.ShopTypes.Normal,
            ItemType.ShopTypes.JingniuCheng,
            ItemType.ShopTypes.UberEats,
        };

        public ObservableCollection<ItemType.ShopTypes> ChoiceList 
        {
            get { return _ChoiceList; }
            set { _ChoiceList = value; }
        }
        #endregion

        #region SeletedValue
        private ItemType.ShopTypes _SeletedItem = ItemType.ShopTypes.Normal;
        public ItemType.ShopTypes SeletedItem 
        {
            get { return _SeletedItem; }
            set { _SeletedItem = value; }
        }
        #endregion
    }
}
