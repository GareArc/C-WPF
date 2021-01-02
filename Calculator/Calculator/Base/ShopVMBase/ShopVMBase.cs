using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    class ShopVMBase : ViewModelBase, IShopVM
    {
        public GlobalVM globalVM { get; set; } = GlobalVM.GetInstance();
        public IWindowFactory windowF;
        public Action CloseWindow;
        public ShopVMBase(IWindowFactory windowF) 
        {
            this.windowF = windowF;
            UpdateChoiceList();
            // Inner notification
            globalVM.PropertyChanged += TargetsPropertyChanged;


        }

        #region Basic Info
        public virtual Shops ShopType { get; } = Shops.CustomShop;
        #endregion

        #region Additional fees
        public virtual string Tip { get; set; } = "0";
        public virtual string Other { get; set; } = "0";
        #endregion

        #region ViewLists
        // SharedList
        public ObservableCollection<ShoppingItem> SharedList { get; set; } = new ObservableCollection<ShoppingItem>();
        public ShoppingItem SeletedItem_SharedList { get; set; }

        // Target1List
        public ObservableCollection<ShoppingItem> Target1List { get; set; } = new ObservableCollection<ShoppingItem>();
        public ShoppingItem SeletedItem_Target1List { get; set; }

        //Targe2List
        public ObservableCollection<ShoppingItem> Target2List { get; set; } = new ObservableCollection<ShoppingItem>();
        public ShoppingItem SeletedItem_Target2List { get; set; }

        //TwoPeopleList
        public ObservableCollection<SharedItem> TwoPeopleList { get; set; } = new ObservableCollection<SharedItem>();
        public SharedItem SeletedItem_TwoPeopleList { get; set; }
        #endregion

        #region ComboBox
        public List<string> ChoiceList_Relation { get; set; } = new List<string>();


        public int SeletedIndex_Relation { get; set; } = 0;

        private void UpdateChoiceList() 
        {
            ChoiceList_Relation = new List<string>
            {
                string.Format("我和{0}", globalVM.Target1),
                string.Format("我和{0}", globalVM.Target2),
                string.Format("{0}和{1}", globalVM.Target1, globalVM.Target2)
            };
        }
        #endregion

        #region Common Cmds
        public virtual BasicItem CreateBasicItem() { MessageBox.Show("没有override创建物品method(Basic)"); return null; }
        public virtual SharedItem CreateSharedItem() { MessageBox.Show("没有override创建物品method(Shared)"); return null; }

        public void SetCloseWindowAction(Action CloseWindow) 
        {
            this.CloseWindow = CloseWindow;
        }
        #endregion

        #region SharedList Add/Delete ButtonCmds
        public ICommand SharedAddBtnCmd { get { return new UnconditionalCmd(SharedListAdd); } }
        public ICommand SharedDeleteBtnCmd { get { return new ConditionalCmd(DeleteFromSharedList, CanDeleteFromSharedList); } }

        private void SharedListAdd(object parameter) 
        {
            ShoppingItem item = CreateBasicItem();
            if (item == null) return;

            SharedList.Add(item);
            globalVM.SharedListTotal.Add(item);
        }

        private bool CanDeleteFromSharedList(object parameter) { return SeletedItem_SharedList != null; }
        private void DeleteFromSharedList(object parameter) 
        {
            globalVM.DeleteFromSharedListTotal(SeletedItem_SharedList);
            SharedList.Remove(SeletedItem_SharedList);
        }
        #endregion

        #region Target1List Add/Delte ButtonCmds
        public ICommand Target1ListAddBtnCmd { get { return new UnconditionalCmd(Target1ListAdd); } }
        public ICommand Target1ListDeleteBtnCmd { get { return new ConditionalCmd(DeleteFromTarget1List, CanDeleteFromTarget1List); } }

        private void Target1ListAdd(object parameter)
        {
            ShoppingItem item = CreateBasicItem();
            if (item == null) return;

            Target1List.Add(item);
            globalVM.Target1ListTotal.Add(item);
        }
        private bool CanDeleteFromTarget1List(object parameter) { return SeletedItem_Target1List != null; }
        private void DeleteFromTarget1List(object parameter) 
        {
            globalVM.DeleteFromTarget1ListTotal(SeletedItem_Target1List);
            Target1List.Remove(SeletedItem_Target1List);
        }
        #endregion

        #region Target2List Add/Delte ButtonCmds
        public ICommand Target2ListAddBtnCmd { get { return new UnconditionalCmd(Target2ListAdd); } }
        public ICommand Target2ListDeleteBtnCmd { get { return new ConditionalCmd(DeleteFromTarget2List, CanDeleteFromTarget2List); } }

        private void Target2ListAdd(object parameter)
        {
            ShoppingItem item = CreateBasicItem();
            if (item == null) return;

            Target2List.Add(item);
            globalVM.Target2ListTotal.Add(item);
        }
        private bool CanDeleteFromTarget2List(object parameter) { return SeletedItem_Target2List != null; }
        private void DeleteFromTarget2List(object parameter) 
        {
            globalVM.DeleteFromTarget2ListTotal(SeletedItem_Target2List);
            Target2List.Remove(SeletedItem_Target2List);
        }
        #endregion

        #region TwoPeopleList Add/Delte ButtonCmds
        public ICommand TwoPeopleAddCmd { get { return new UnconditionalCmd(TwoPeopleListAdd); } }
        public ICommand TwoPeopleDeleteCmd { get { return new ConditionalCmd(DeleteFromTwoPeople, TwoPeopleCanDelte); } }

        private void TwoPeopleListAdd(object parameter) 
        {
            SharedItem item = CreateSharedItem();
            if (item == null) return;

            TwoPeopleList.Add(item);
            switch (item.RelationType)
            {
                case Relation.MeAndTarget1:
                    globalVM.AddToTarget1ListTotal(item);
                    return;
                case Relation.MeAndTarget2:
                    globalVM.AddToTarget2ListTotal(item);
                    return;
                case Relation.Target1AndTarget2:
                    globalVM.AddToTarget1ListTotal(item);
                    globalVM.AddToTarget2ListTotal(item);
                    return;
            }
        }

        private bool TwoPeopleCanDelte(object parameter) { return SeletedItem_TwoPeopleList != null; }
        private void DeleteFromTwoPeople(object paramerter) 
        {
            
            switch (SeletedItem_TwoPeopleList.RelationType) 
            {
                case Relation.MeAndTarget1:
                    globalVM.DeleteFromTarget1ListTotal(SeletedItem_TwoPeopleList);
                    break;
                case Relation.MeAndTarget2:
                    globalVM.DeleteFromTarget2ListTotal(SeletedItem_TwoPeopleList);
                    break;
                case Relation.Target1AndTarget2:
                    globalVM.DeleteFromTarget1ListTotal(SeletedItem_TwoPeopleList);
                    globalVM.DeleteFromTarget2ListTotal(SeletedItem_TwoPeopleList);
                    break;
            }
            TwoPeopleList.Remove(SeletedItem_TwoPeopleList);
        }
        #endregion

        #region ConfirmButton
        public ICommand ConfirmCmd { get { return new ConditionalCmd(Confirm, CanConfirm); } }

        private bool CanConfirm(object parameter) 
        {
            try
            {
                double.Parse(Tip);
                double.Parse(Other);
            }
            catch (Exception e) { return false; }
            return true;
        }

        public virtual void Confirm(object parameter) 
        {
            globalVM.ShopTips[ShopType] = double.Parse(Tip);
            globalVM.ShopOthers[ShopType] = double.Parse(Other);
            CloseWindow();
        }
        #endregion

        #region InnerPropertyChanges
        public void TargetsPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            if (e.PropertyName == "Target1") UpdateChoiceList();
            if (e.PropertyName == "Target2") UpdateChoiceList();
        }
        #endregion

        #region Helper
        public Relation GetRelationType() 
        {
            switch (SeletedIndex_Relation) 
            {
                case 0:
                    return Relation.MeAndTarget1;
                case 1:
                    return Relation.MeAndTarget2;
                case 2:
                    return Relation.Target1AndTarget2;
                default:
                    return Relation.MeAndTarget1;
            }
        }
        #endregion




    }
}
