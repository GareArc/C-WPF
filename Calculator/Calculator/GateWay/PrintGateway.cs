using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    class PrintGateway
    {
        private GlobalVM GlobalVM = GlobalVM.GetInstance();
        private MainWindowVM MainWindowVM;

        public PrintGateway(MainWindowVM MainWindowVM) 
        {
            this.MainWindowVM = MainWindowVM;
        }

        public void Print()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "购物清单.txt");
            StringBuilder txt = new StringBuilder();

            // Shared part
            txt.AppendLine("================= 基础部分 =================");
            txt.AppendLine(string.Format("电费: {0}", MainWindowVM.DF));
            txt.AppendLine(string.Format("网费: {0}", MainWindowVM.WF));
            txt.AppendLine(string.Format("Amazon费: {0}", MainWindowVM.AMZ));
            txt.AppendLine(string.Format("Amazon会员费: {0}", MainWindowVM.AMZP));
            txt.AppendLine(string.Format("外卖费: {0}", MainWindowVM.WM));
            txt.AppendLine(string.Format("其他费用: {0}", MainWindowVM.QT));

            txt.AppendLine("================= 商店额外 =================");
            foreach (var k in GlobalVM.ShopTips.Keys) 
            {
                txt.AppendLine(string.Format("{0} | 小费: {1}, 其他: {2}", GLOBAL.GetDescription(k), GlobalVM.ShopTips[k], GlobalVM.ShopOthers[k]));
            }
            
            txt.AppendLine("================= 购物部分 =================");
            foreach (var item in GlobalVM.SharedListTotal)
            {
                txt.AppendLine(item.ToString());
            }

            // Individual part
            txt.AppendLine("================= 三人部分 =================");
            // Target 1
            txt.AppendLine(string.Format("\n{0} 部分:", GlobalVM.Target1));
            foreach (var item in GlobalVM.Target1ListTotal)
            {
                txt.AppendLine(item.ToString());
            }

            // Target 2
            txt.AppendLine(string.Format("\n{0} 部分:", GlobalVM.Target2));
            foreach (var item in GlobalVM.Target2ListTotal)
            {
                txt.AppendLine(item.ToString());
            }

            // Conclution
            txt.AppendLine("================= 总结 =================");
            txt.AppendLine(MainWindowVM.User1Result);
            txt.AppendLine(MainWindowVM.User2Result);

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
