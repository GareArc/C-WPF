using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    partial class AddItem2ViewModel : ViewModelbase
    {
        private ItemListViewModel ItemLM = ItemListViewModel.GetInstance();
        private UserViewModel um = UserViewModel.GetInstance();
        public AddItem2ViewModel(int rid, string r) 
        {
            Relation = r;
            RelationId = rid;
            //Command
            ComfirmCmd = new ConditionalCmd(Comfirm, CanComfirm);
        }

    }
}
