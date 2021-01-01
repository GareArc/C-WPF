using System.ComponentModel;
namespace MVVM
{
    partial class AddItem1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ItemListViewModel ItemLM = ItemListViewModel.GetInstance();


        public AddItem1ViewModel(int source) 
        { 
            Source = source;
            ComfirmCmd = new ConditionalCmd(Comfirm, CanComfirm);
        }

    }
}
