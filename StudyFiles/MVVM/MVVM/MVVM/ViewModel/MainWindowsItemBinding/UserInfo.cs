using System.Collections.Generic;
using System.ComponentModel;

namespace MVVM
{
    partial class MainWindowItems
    {

        private void UserMangerPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            if (e.PropertyName == "Target1User") 
            {
                Target1Result = string.Format("{0}总计: {1}", um.Target1User, Target1Total);
                RaisePropertyChanged("Target1Result");
            }

            if (e.PropertyName == "Target2User") 
            {
                Target2Result = string.Format("{0}总计: {1}", um.Target2User, Target2Total);
                RaisePropertyChanged("Target2Result");
            }

        }

    }
}
