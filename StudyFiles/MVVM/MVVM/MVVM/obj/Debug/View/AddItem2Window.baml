   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVM.View	MVVM.View  5   	       MVVM.View.AddItem2Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MVVM.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 添加物品��5	   	   $	��260��6   $	��500��6#   .��5
      �� $��5q�6   ._�5   
   �� .+�5      � $��
10 20 10 0q�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   .+�5      �� $��类型��6    $��18(�6*   
������� �� TextAlignment$ Center=�6O   $��Center=�6f   $
��Bold"�6�   $��
10 0 10 20q�6�   �� 5      $��0 5 0 0q�6   $��85��60   $��25��6;   ��6G   �� *
ChoiceList+ �� SelectedItem 6j   �� *SeletedItem+ �� Mode$ TwoWay=�6�   5      �� 5      $��1��6   .+�5      �� $��单价��6    $��18(�6*   
�������$ Center=�6O   $��Center=�6f   $
��Bold"�6�   $��
10 0 10 20q�6�   �� 5      $��Center=�6k   $��Center=�6�   $��20(�6�   $��40��6�   $��	10 0 10 0q�6�   ��6   �� *	PriceText+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      �� 5!      $��2��6   .+�5"      �� $��数量��6    $��18(�6*   
�������$ Center=�6O   $��Center=�6f   $
��Bold"�6�   $��
10 0 10 20q�6�   �� 5#      $��Center=�6n   $��Center=�6�   $��20(�6�   $��40��6�   $��	10 0 10 0q�6�   ��6   �� *QuantityText+$ TwoWay=�$ PropertyChanged=�6�   5$      �� 5&      $��3��6   .+�5'      �� $��是否收税��6    $��18(�6,   
�������$ Center=�6Q   $��Center=�6h   $
��Bold"�6�   $��
10 0 10 20q�6�   �� 5(      $��Center=�6q   $��0 6 0 0q�6�    d� 	IsChecked 6   �� *	TaxedText+$ TwoWay=�$ PropertyChanged=� � LayoutTransform 5)      �� 5*      	 �� ScaleX$	 2Q�6-   
 �� ScaleY$
 2Q�68   5,      5-      5.      �� 50      $��确认��6g   $��20(�6t   $
��Bold"�6�   $��80��6�   $��Center=�6�   $��	 0 50 0 0q�6�   ��6   �� *
ComfirmCmd+$ PropertyChanged=� �� IsAsync . 6�   51      52      53      