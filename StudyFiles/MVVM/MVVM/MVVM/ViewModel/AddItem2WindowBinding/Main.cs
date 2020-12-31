using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    partial class MainAddItem2Items : ViewModelbase
    {
        private ItemListsManager ItemLM = ItemListsManager.GetInstance();
        private UserManager um = UserManager.GetInstance();
        public MainAddItem2Items(int rid, string r) 
        {
            Relation = r;
            RelationId = rid;
            //Command
            ComfirmCmd = new ConditionalCmd(Comfirm, CanComfirm);
        }

    }
}
