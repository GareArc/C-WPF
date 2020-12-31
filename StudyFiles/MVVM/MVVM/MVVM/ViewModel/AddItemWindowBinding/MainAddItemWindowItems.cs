using System.ComponentModel;
namespace MVVM
{
    partial class AddItemWindowItems : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ItemListsManager ItemLM = ItemListsManager.GetInstance();


        public AddItemWindowItems(int source) 
        { 
            Source = source;
            ComfirmCmd = new ConditionalCmd(Comfirm, CanComfirm);
        }

    }
}
