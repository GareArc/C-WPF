
using System.Collections.Generic;

namespace Calculator
{
    partial class MainWindowVM
    {
        public string DF { get; set; } = "0";
        public string WF { get; set; } = "50.85";
        public string AMZ { get; set; } = "5.3";
        public string AMZP { get; set; } = "0";
        public string WM { get; set; } = "0";
        public string QT { get; set; } = "0";

        #region CheckBoxes IsChecked Attributes
        public bool C1 { get { return !R1; } set { R1 = !value; } }
        public bool C2 { get { return !R2; } set { R2 = !value; } }
        public bool C3 { get { return !R3; } set { R3 = !value; } }
        public bool C4 { get { return !R4; } set { R4 = !value; } }
        public bool C5 { get { return !R5; } set { R5 = !value; } }
        public bool C6 { get { return !R6; } set { R6 = !value; } }
        #endregion

        #region TextBoxes IsReadOnly Attributes
        public bool R1 { get; set; } = true;
        public bool R2 { get; set; } = true;
        public bool R3 { get; set; } = true;
        public bool R4 { get; set; } = true;
        public bool R5 { get; set; } = true;
        public bool R6 { get; set; } = true;


        #endregion

    }
}
