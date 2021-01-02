using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    partial class GlobalVM
    {
        #region Item info from AddItemWindow
        public bool AddedNewItem { get; set; } = false;
        public double LastItemPrice { get; set; }
        public double LastItemQuantity { get; set; }
        public bool LastItemIsTaxed { get; set; }
        #endregion

    }
}
