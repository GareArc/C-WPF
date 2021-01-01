using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace MVVM
{
    partial class MainWindowItems
    {
        public ICommand dfCheck { get { return new UnconditionalCmd(dfCheckExecute); } }
        public ICommand wfCheck { get { return new UnconditionalCmd(wfCheckExecute); } }
        public ICommand amzCheck { get { return new UnconditionalCmd(amzCheckExecute); } }
        public ICommand amzpCheck { get { return new UnconditionalCmd(amzpCheckExecute); } }
        public ICommand wmCheck { get { return new UnconditionalCmd(wmCheckExecute); } }
        public ICommand qtCheck { get { return new UnconditionalCmd(qtCheckExecute); } }

        private void dfCheckExecute(object parameter) 
        {
            var a = DfC;
            var b = DfB;
            CheckExecuteHelper(ref a, ref b);
            DfC = a;
            DfB = b;
        }
        private void wfCheckExecute(object parameter)
        {
            var a = WfC;
            var b = WfB;
            CheckExecuteHelper(ref a, ref b);
            WfC = a;
            WfB = b;
        }
        private void amzCheckExecute(object parameter)
        {
            var a = AmzC;
            var b = AmzB;
            CheckExecuteHelper(ref a, ref b);
            AmzC = a;
            AmzB = b;
        }
        private void amzpCheckExecute(object parameter)
        {
            var a = AmzpC;
            var b = AmzpB;
            CheckExecuteHelper(ref a, ref b);
            AmzpC = a;
            AmzpB = b;
        }
        private void wmCheckExecute(object parameter)
        {
            var a = WmC;
            var b = WmB;
            CheckExecuteHelper(ref a, ref b);
            WmC = a;
            WmB = b;
        }
        private void qtCheckExecute(object parameter)
        {
            var a = QtC;
            var b = QtB;
            CheckExecuteHelper(ref a, ref b);
            QtC = a;
            QtB = b;
        }

        private void CheckExecuteHelper(ref bool IsReadOnly, ref Brush bc) 
        {
            IsReadOnly = !IsReadOnly;
            if (IsReadOnly)bc = Brushes.Gray;
            else bc = Brushes.White;

        }

    }
}
