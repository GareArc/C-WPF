   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 6<   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source *  &ComboBoxItem.ItemsviewHover.Background �� Color & "ComboBoxItem.ItemsviewHover.Border - )ComboBoxItem.ItemsviewSelected.Background ) %ComboBoxItem.ItemsviewSelected.Border 2 .ComboBoxItem.ItemsviewSelectedHover.Background . *ComboBoxItem.ItemsviewSelectedHover.Border 4 0ComboBoxItem.ItemsviewSelectedNoFocus.Background 0 ,ComboBoxItem.ItemsviewSelectedNoFocus.Border & "ComboBoxItem.ItemsviewFocus.Border /	 +ComboBoxItem.ItemsviewHoverFocus.Background +
 'ComboBoxItem.ItemsviewHoverFocus.Border  BlueComboBoxItemStyle �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorType  BlueVeryLightBrush  BlueLightBrush �� 
TargetType	 ��Name
 �� Padding J� SnapsToDevicePixels �� Triggers P� Property P� Value  ComboBox.Static.Background �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border  ComboBox.MouseOver.Glyph ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border /  +ComboBox.Pressed.Editable.Button.Background +! 'ComboBox.Pressed.Editable.Button.Border " ComboBox.Disabled.Glyph  # ComboBox.Disabled.Background $ ComboBox.Disabled.Border )% %ComboBox.Disabled.Editable.Background %& !ComboBox.Disabled.Editable.Border 0' ,ComboBox.Disabled.Editable.Button.Background ,( (ComboBox.Disabled.Editable.Button.Border ) ComboBox.Static.Glyph * ComboBoxToggleButton F�Name ^� 
Conditions �� Binding �� Value �� 
TargetName + ComboBoxTemplate �Name � ColumnDefinitions �Name � AllowsTransparency �� Mode5   /Microsoft.Windows.Themes.SystemDropShadowChrome   Name    Color �� MaxDropDownHeight  �� ElementName! ��Name" �� ClearTypeHint# ��Name$ ��Name% ��Name-  'System.Windows.Input.KeyboardNavigation&   DirectionalNavigation' d�Name( d� 	IsChecked) ��Name* �� SelectionBoxItemTemplate+ �� SelectionBoxItem#, �� SelectionBoxItemStringFormat- �� ContentStringFormat. J� IsHitTestVisible/ P� 
SourceName0 ]� 
Conditions1 �� Property , TextBox.Static.Background - ComboBoxEditableTextBox . ComboBoxEditableTemplate2 ��Name3 �� 
IsReadOnly / BlueComboBoxStyle4 �� Triggers�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      "localclr-namespace:Calculator  5      VThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  6<     5      �� 5   
   $ Colors.xaml?�6   %�2  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     &	     &		 ;    &	
 ^    &	 �    7  7  7  7  &	 �    &	 6    &	 Y    &	 |    &	 �    &	 �    &	 �    &	     &	 �    &	 �    &	 �    &	     &	 �    &	 �    &	 �    &	 �    &	 �    &	 �    &	  �    &	! �	    &	" �	    &	# �	    &	$ �	    &	%  
    &	& C
    &	' f
    &	( �
    &	) �
    &	* �
    7  7  7 ) 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7 ! 7 " 7 # 7 $ 7 % 7 & 7 ' 7 ( &	+ �    7 * &	, n!    &	- �!    &	. �#    7 * 7 , 7 - &	/ $-    7  7  7 + 7  7 . �� 5	      $ 	#1F26A0DA��6E   �� 5
      $ 	#A826A0DA��6A   �� 5      $ 	#3D26A0DA��6H   �� 5      $ 	#FF26A0DA��6D   �� 5      $ 	#2E0080FF��6M   �� 5      $ 	#99006CD9��6I   �� 5      $ 	#3DDADADA��6O   �� 5      $ 	#FFDADADA��6K   �� 5      $ 	#FF26A0DA��6A   �� 5      $ 	#5426A0DA��6J   �� 5      $ 	#FF26A0DA��6F   �� 5      " ��6*   .�5   
   ��  �@J�SnapsToDevicePixels . 60   �� 5   
    � ��$	 4,1q�6$   �� 5   
    � �� 67   �� *HorizontalContentAlignment+ �� " ���� 5   
    � �� 65   �� *VerticalContentAlignment+ �� " ���� 5   
    � ��8   6'   �� 5   
    � ��8  6(   �� 5   
    � ��$ 1q�6,   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $	 Bd��6   #��z��6)   #��z��6U   #��z��6�   #
 z��6�    . ._�5       �� #��z��6+   # z 6n   #��z��6�   5!       5"      P� 5#       �@��
IsSelected . . �5$      �� 8   � ��6;   5%      P� 5&       �@J�IsMouseOver . . �5'      �� 8   � ��6;   5(      5*      5,      5-      �� 51      $	 0,1&�6=   $	 0,0&�6L   .��52   
   � $ 	#FFF0F0F0��6   $	 0.0Q�6)   � 53   
   $ 	#FFE5E5E5��6   $	 1.0Q�6)   54      �� 55      $ 	#FFACACAC��65   �� 56      $ 	#FFFFFFFF��6B   �� 57      $ 	#FFABADB3��6>   �� 58      $ Transparent��6I   �� 59      $ Transparent��6E   �� 5:      $ 	#FF000000��67   �� 5;      $	 0,1&�6@   $	 0,0&�6O   .��5<   
   � $ 	#FFECF4FC��6   $	 0.0Q�6)   � 5=   
   $ 	#FFDCECFC��6   $	 1.0Q�6)   5>      �� 5?      $ 	#FF7EB4EA��68   �� 5@      $ 	#FFFFFFFF��6E   �� 5A      $ 	#FF7EB4EA��6A   �� 5B      $	 0,1&�6P   $	 0,0&�6_   .��5C   
   � $ 	#FFEBF4FC��6   $	 0.0Q�6)   � 5D   
   $ 	#FFDCECFC��6   $	 1.0Q�6)   5E      �� 5F      $ 	#FF7EB4EA��6H   �� 5G      $ 	#FF000000��65   �� 5H      $	 0,1&�6>   $	 0,0&�6M   .��5I   
   � $ 	#FFDAECFC��6   $	 0.0Q�6)   � 5J   
   $ 	#FFC4E0FC��6   $	 1.0Q�6)   5K      �� 5L      $ 	#FF569DE5��66   �� 5M      $ 	#FFFFFFFF��6C   �� 5N      $ 	#FF569DE5��6?   �� 5O      $	 0,1&�6N   $	 0,0&�6]   .��5P   
   � $ 	#FFDAEBFC��6   $	 0.0Q�6)   � 5Q   
   $ 	#FFC4E0FC��6   $	 1.0Q�6)   5R      �� 5S      $ 	#FF569DE5��6F   �� 5T      $ 	#FFBFBFBF��66   �� 5U      $ 	#FFF0F0F0��6;   �� 5V      $ 	#FFD9D9D9��67   �� 5W      $ 	#FFFFFFFF��6D   �� 5X      $ 	#FFBFBFBF��6@   �� 5Y      $ Transparent��6K   �� 5Z      $ Transparent��6G   �� 5[      $ 	#FF606060��64   �� 5\      " d�6)   .�5]   
   ��  �@�OverridesDefaultStyle . 62   �� 5^   
    � �� .  6&   �� 5_   
    � |� .  6&   �� 5`   
    �@��	ClickMode$ Press=�6&   �� 5a   
    � �� 5b      �� 5c      " d�6"   .R�5d      �� $	 templateRoot��6   8��  #��z��6i   8��  . ._�5e      �� $	 splitBorder��6!   
������ $��1q�6P   $��Right=�6d   $��0q�6�    . #��� r�6�   ._�5f      F� $ arrow��6#   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5g      5h       5i      ^� 5j       5k      �� 5l   "    6,   �� *
IsEditable+ �� " �� true6�   �� 5m   "    6,   �� *IsMouseOver+ �� *Self+	 false6r   �� 5n   "    6,   �� *	IsPressed+ �� *Self+	 false6p   �� 5o   "    6,   �� *	IsEnabled+ �� *Self+ true6p   .0�5q      �� $ templateRoot��6;   8   � ��6U   �� 5r      $ templateRoot��6<   8   � ��6V   �� 5s      $ splitBorder��6;   8   � ��6T   �� 5t      $ splitBorder��6<   8   � ��6U   5u      P� 5v       �@J�IsMouseOver . . �5w      �� $ arrow��65   8   � ��6H   5x      ^� 5y       5z      �� 5{   "    6,   �� *IsMouseOver+ �� *Self+ true6r   �� 5|   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5~      �� $ templateRoot��6;   8   � ��6U   �� 5      $ templateRoot��6<   8 	  � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *IsMouseOver+ �� *Self+ true6r   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8 
  � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   �� 5�      $ splitBorder��6;   8   � ��6T   �� 5�      $ splitBorder��6<   8   � ��6U   5�      P� 5�       � �� . . �5�      �� $ arrow��65   8   � ��6H   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsPressed+ �� *Self+ true6p   �� 5�   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsPressed+ �� *Self+ true6p   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   �� 5�      $ splitBorder��6;   8   � ��6T   �� 5�      $ splitBorder��6<   8   � ��6U   5�      P� 5�       � {� .  . �5�      �� $ arrow��65   8   � ��6H   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsEnabled+ �� *Self+	 false6p   �� 5�   "    6,   �� *
IsEditable+ �� " ��	 false6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   5�      ^� 5�       5�      �� 5�   "    6,   �� *	IsEnabled+ �� *Self+	 false6p   �� 5�   "    6,   �� *
IsEditable+ �� " �� true6�   .0�5�      �� $ templateRoot��6;   8   � ��6U   �� 5�      $ templateRoot��6<   8   � ��6V   �� 5�      $ splitBorder��6;   8   � ��6T   �� 5�      $ splitBorder��6<   8   � ��6U   5�      5�      5�      5�      �� 5�      " ��6/   .R�5�   
   � $ templateRoot��6    .  5�      �� 5�      $��* �6#   �� 5�      #��� r�6#   $��0 �6v   .+�5�      � $ 
PART_Popup��6    . $��2��6B   $��1q�6�   #��� .�6�   $��Bottom=�6  ��6V   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+.��5�         $ shadow��60   $ Transparent��6@   #��z 6T   ��6�   �� *ActualWidth+$  templateRoot��._�5�      �� $	 dropDownBorder��6   #��� ��65   $��1q�6�   #��� ��6�   ._�5�      �� $! DropDownScrollViewer��6'   .��5�      � $
 grid��6#   $" Enabled=�61   .+�5�   "   �� $# canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5�   &   �� $$ 
opaqueRect��60   ��6D   �� *
Background+$  dropDownBorder����6|   �� *ActualHeight+$  dropDownBorder����6�   �� *ActualWidth+$  dropDownBorder��5�   #   �� 5�   "   $% ItemsPresenter��61   $& 	Contained=�6I   # z 6~   5�      5�      5�      5�      5�      d� 5�      $' toggleButton��6   #��z��61   #��z��6]   #��z��6�   $��2��6�   8��  ( 6�   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+62  �� 5�      $) contentPresenter��6   #��z* 69   #��z��6v   #��z+ 6�   #- z, 6�   #��z��6)  . .  #��z��6�  # z 6�  #��z��6�  5�       5�   
   P� 5�      $/ 
PART_Popup��6/    �@�HasDropShadow . . �5�      �� $ shadow��6+    � ��$ 0,0,5,5q�6?   �� 5�      $ shadow��6*    �@  Color$ 	#71000000��6>   5�      P� 5�       �@��HasItems .  . �5�      �� $ dropDownBorder��6+    � ��$ 95��6G   5�      ]� 5�      0 5�      �� 5�      1 �@��
IsGrouping . 66   �� 5�      "1 �@%�IsVirtualizingWhenGrouping .  6X   ./�5�      ��  � �� .  6B   5�      P� 5�      $/ DropDownScrollViewer��6?    � �� .  . �5�      �� $ 
opaqueRect��6/    6G   �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� 5�      $ 
opaqueRect��60    6H   �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left5�      5�      �� 5�      $ 	#FFFFFFFF��68   �� 5�      " ��6,   .�5�   
   ��  �@�OverridesDefaultStyle . 62   �� 5�   
    �@J�	AllowDrop . 6&   �� 5�   
    � ��$ 0��6%   �� 5�   
    � ��$ 0��6&   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    �@��PanningMode$ VerticalFirst=�65   �� 5�   
    �@��IsFlicksEnabled .  63   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $! PART_ContentHost��6#   
������ |�.  $��Hidden=�6h   $��Hidden=�6�   5�      5�      5�      �� 5�      " ��67   .R�5�   
   � $ templateRoot��6    .  5�      �� 5�      $��* �6#   �� 5�      #��� r�6#   $��0 �6v   .+�5�      � $ 
PART_Popup��6    . $��2��6B   #��� .�6�   $��Bottom=�6  ��6V   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�         $ shadow��60   $ Transparent��6@   #��z 6T   ��6�   �� *ActualWidth+$  templateRoot��._�5�      �� $	 dropDownBorder��6   #��� ��65   $��1q�6�   #��� ��6�   ._�5      �� $! DropDownScrollViewer��6'   .��5     � $
 grid��6#   $" Enabled=�61   .+�5  "   �� $# canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5  &   �� $$ 
opaqueRect��60   ��6D   �� *
Background+$  dropDownBorder����6|   �� *ActualHeight+$  dropDownBorder����6�   �� *ActualWidth+$  dropDownBorder��5  #   �� 5  "   $% ItemsPresenter��61   $& 	Contained=�6I   # z 6~   5     5     5     5	     5
     d� 5     $' toggleButton��6   #��z��61   #��z��6]   #��z��6�   $��2��6�   8��  ( 6�   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+62  �� 5     $	 border��6   8�� #��z��6]   ._�5     �� $2 PART_EditableTextBox��6   #��z��68   #��z��6�   8�� #��z��6)  3 6�   �� *
IsReadOnly+ �� *TemplatedParent+6)  5     5      5  
   P� 5      � {� .  . �5     �� $ border��6,    �@J�Opacity$
 0.56Q�6@   5     P� 5      �@J�IsKeyboardFocusWithin . . �5     ��  � ��
 �   �6/   5     P� 5     $/ 
PART_Popup��6/    �@�HasDropShadow . . �5     �� $ shadow��6+    � ��$ 0,0,5,5q�6?   �� 5     $ shadow��6*    �@  Color$ 	#71000000��6>   5     P� 5      �@��HasItems .  . �5     �� $ dropDownBorder��6+    � ��$ 95��6G   5     ]� 5     0 5     �� 5      1 �@��
IsGrouping . 66   �� 5!     "1 �@%�IsVirtualizingWhenGrouping .  6X   ./�5#     ��  � �� .  6B   5$     P� 5%     $/ DropDownScrollViewer��6?    � �� .  . �5&     �� $ 
opaqueRect��6/    6G   �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� 5'     $ 
opaqueRect��60    6H   �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left5(     5*     �� 5-     " ��6&   .�5.  
   ��  � ��8   6'   �� 5/  
    � ��8  6(   �� 50  
    � ��# � ��6'   �� 51  
    � ��$ 1q�6,   �� 52  
    � ��$
 Auto=�6G   �� 53  
    � ��$
 Auto=�6E   �� 54  
    � ��$ 6,3,5,3q�6$   �� 55  
    � �� . 6:   �� 56  
    �@��PanningMode$
 Both=�65   �� 57  
    �@��IsFlicksEnabled .  63   �� 58  
    � ��8  6%   �� 59  
    � ��8  6/   �� 5:  
    � ��$ 26��6#   �� 5;  
    � ��$ 16(�6%   �� 5<  
    � ��$ Heavy"�6'   �� 5=  
    � ��$ Center=�6.   �� 5>  
    � ��$ Center=�65   4 5@  
   P� 5A      �@��
IsEditable . . �5B     ��  � �� .  6.   �� 5C      � ��$ 2q�6,   �� 5D      � ��8  6-   5E     5G     5K     