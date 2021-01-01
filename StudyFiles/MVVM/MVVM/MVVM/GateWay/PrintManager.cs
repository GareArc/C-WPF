using System;
using System.IO;
using System.Text;
using System.Windows;

namespace MVVM
{
    class PrintManager
    {
        private MainWindowItems main;
        private ItemListsManager im = ItemListsManager.GetInstance();
        private UserManager um = UserManager.GetInstance();

        public PrintManager(MainWindowItems main) { this.main = main; }

        public void Print()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "购物清单.txt");
            StringBuilder txt = new StringBuilder();

            // Shared part
            txt.AppendLine("================= 基础部分 =================");
            if (!main.DfC) txt.AppendLine(string.Format("电费: {0}", main.Df));
            if (!main.WfC) txt.AppendLine(string.Format("网费: {0}", main.Wf));
            if (!main.AmzC) txt.AppendLine(string.Format("Amazon费: {0}", main.Amz));
            if (!main.AmzpC) txt.AppendLine(string.Format("Amazon会员费: {0}", main.Amzp));
            if (!main.WmC) txt.AppendLine(string.Format("外卖费: {0}", main.Wm));
            if (!main.QtC) txt.AppendLine(string.Format("其他费用: {0}", main.Qt));
            txt.AppendLine("================= 购物部分 =================");
            foreach (var item in im.SharedList)
            {
                txt.AppendLine(item.ToString());
            }

            // Individual part
            txt.AppendLine("================= 个人部分 =================");
            // Target 1
            txt.AppendLine(string.Format("\n{0} 部分:", um.Target1User));
            foreach (var item in im.ItemList1)
            {
                txt.AppendLine(item.ToString());
            }

            // Target 2
            txt.AppendLine(string.Format("\n{0} 部分:", um.Target2User));
            foreach (var item in im.ItemList2)
            {
                txt.AppendLine(item.ToString());
            }

            // Two People part
            txt.AppendLine("================= 双人部分 =================");
            foreach (var item in im.TwoPeopleTotalList)
            {
                txt.AppendLine(item.ToString());
            }

            // Conclution
            txt.AppendLine("================= 总结 =================");
            txt.AppendLine(string.Format("{0} 总计: {1}", um.Target1User, main.Target1Total));
            txt.AppendLine(string.Format("{0} 总计: {1}", um.Target2User, main.Target2Total));

            // Print
            try
            {
                File.WriteAllText(path, txt.ToString());
                
            }
            catch (IOException E) { MessageBox.Show("请检查软件地址是否有名为\"购物账单.txt\"的文件"); return; }
            MessageBox.Show("生成成功,请检查存放软件的目录。");

        }
    }
}