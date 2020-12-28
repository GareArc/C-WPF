using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FisrtWPF
{
    class PanelHandler
    {
        private ItemManager iM = new ItemManager();
        public PanelHandler() { }

        public void AddTextBlock(StackPanel panel, string info)
        {
            if (panel.Children.Count > 16) return;
            var NewTextBlock = new TextBlock();
            NewTextBlock.Text = info;
            NewTextBlock.FontSize = 10;
            // Set margin
            var margin = NewTextBlock.Margin;
            margin.Top = 5;
            NewTextBlock.Margin = margin;

            // If there are 15 items, hide the new item.
            if (panel.Children.Count == 16) NewTextBlock.Text = "...";
            // Add to panel
            panel.Children.Add(NewTextBlock);
        }
    }
}
