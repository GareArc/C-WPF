using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace MVVM
{
    partial class MainWindowItems
    {
        private string _Df = "0";
        private string _Wf = "50.85";
        private string _Amz = "0";
        private string _Amzp = "5.3";
        private string _Wm = "0";
        private string _Qt = "0";

        private bool _DfC  = true;
        private bool _WfC  = true;
        private bool _AmzC = true;
        private bool _AmzpC = true;
        private bool _WmC  = true;
        private bool _QtC = true;

        private Brush _DfB = Brushes.Gray;
        private Brush _WfB = Brushes.Gray;
        private Brush _AmzB = Brushes.Gray;
        private Brush _AmzpB = Brushes.Gray;
        private Brush _WmB = Brushes.Gray;
        private Brush _QtB = Brushes.Gray;

        private double _Target1Total = 0;
        private double _Target2Total = 0;

        private string _Target1Result;
        private string _Target2Result;

        public string Df { get { return _Df;} set { _Df = value; } }
        public string Wf { get { return _Wf; } set { _Wf = value; } }
        public string Amz { get { return _Amz; } set { _Amz = value; } }
        public string Amzp { get { return _Amzp; } set { _Amzp = value; } }
        public string Wm { get { return _Wm; } set { _Wm = value; } }
        public string Qt { get { return _Qt; } set { _Qt = value; } }

        public bool DfC { get { return _DfC; } set { _DfC = value; } }
        public bool WfC { get { return _WfC; } set { _WfC = value; } }
        public bool AmzC { get { return _AmzC; } set { _AmzC = value; } }
        public bool AmzpC { get { return _AmzpC; } set { _AmzpC = value; } }
        public bool WmC { get { return _WmC; } set { _WmC = value; } }
        public bool QtC { get { return _QtC; } set { _QtC = value; } }

        public Brush DfB { get { return _DfB; } set { _DfB = value; } }
        public Brush WfB { get { return _WfB; } set { _WfB = value; } }
        public Brush AmzB { get { return _AmzB; } set { _AmzB = value; } }
        public Brush AmzpB { get { return _AmzpB; } set { _AmzpB = value; } }
        public Brush WmB { get { return _WmB; } set { _WmB = value; } }
        public Brush QtB { get { return _QtB; } set { _QtB = value; } }

        public double Target1Total 
        {
            get { return _Target1Total; }
            set { _Target1Total = value; }
        }
        public double Target2Total
        {
            get { return _Target2Total; }
            set { _Target2Total = value; }
        }

        public string Target1Result { get { return _Target1Result; } set { _Target1Result = value; } }
        public string Target2Result { get { return _Target2Result; } set { _Target2Result = value; } }

    }
}
