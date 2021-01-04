
using System;
using System.Windows.Input;

namespace Calculator
{
    partial class AddItemVM
    {
        #region ConfirmButton
        public ICommand ConfirmCmd { get { return new ConditionalCmd(Confirm, CanConfirm); } }

        private bool CanConfirm(object parameter) 
        {
            try
            {
                double.Parse(PriceText);
                double.Parse(QuantityText);
            }
            catch (Exception e) { return false; }
            return true;
        }

        private void Confirm(object parameter) 
        {
            globalVM.LastItemPrice = double.Parse(PriceText);
            globalVM.LastItemQuantity = double.Parse(QuantityText);
            globalVM.LastItemIsTaxed = IsTaxedText;
            globalVM.AddedNewItem = true;

            CloseWindow();
        }

        #endregion
    }
}
