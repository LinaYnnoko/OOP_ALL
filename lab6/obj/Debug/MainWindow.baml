   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   ? ;lab6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab6lab6 5   	      lab6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   $localclr-namespace:lab6     5   	     � Title$  Rich Text Editor��5	   	   $	��450��6"   $	��800��6/    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      6<     5   
   -   5        $ ApplicationCommands.Save��5      6<     5   
   -   5        $ ApplicationCommands.New��5      6;     5   
   -   5        $ ApplicationCommands.Copy��5      6<     5   
   -   5        $ ApplicationCommands.Paste��5      6=    � 	Resources 5      ��%    5      .��5      �    	GridTheme#���   6    � RowDefinitions 5   
   �� 5      $��* �6   $��25��6'   68   �� 5      $��9* �6   6,   �� 5      $
��0.5* �6   $��10��6+   6<   .+�5   
   c� $��0��6   $��Center=�6   $	��Top=�6<     ToolBarBackground#���  6T   $��
10,0,9.6,0q�6�   $	��774��6�   .@�5      o� -   5         o�Name$
 menu��5      $��Center=�6!   .@�5      m� -   5         m�Name$ fileMenu��5       	 m_New#���  6-   .@�5      m� -   5          	m_OpenNew#���  5   7     MenuItemMouseOverStyle#��[ 6\   6�   m� 5      -	   5          
m_CloseNew#���  5   7   #��[ 6]   6�   m� 5       -
   5         
 m_Save#���  5    7   #��[ 6Y   6�   m� 5!      -   5         
 m_Undo#���  5!   ,   #��[ 6N   m� 5"      -   5         
 m_Redo#���  5"   ,   #��[ 6N   5#      5$      �� 5%      $��ApplicationCommands.Open��6    	 
ButtonLoad#��[	 68   .��5&      �� $��open.png��6   5'      �� 5(      $��ApplicationCommands.Save��6   #��[	 68   .��5)      �� $��save.png��6   5*      �� 5.      �� 5/      $��ApplicationCommands.Copy��6   #��[	 68   .��50      �� $��	files.png��6   51      �� 52      $��ApplicationCommands.Paste��6   #��[	 69   .��53      �� $��	paste.png��6   54      �� 55      d� 56      -   5        $��btnBold��56   @   $ ��EditingCommands.ToggleBold��6   .��57      �� $��bold.png��6   58      d� 59      -   5        $��	btnItalic��59   B   $"��EditingCommands.ToggleItalic��6   .��5:      �� $��
italic.png��6   5;      d� 5<      -   5        $��btnUnderline��5<   E   $%��EditingCommands.ToggleUnderline��6   .��5=      �� $��underline.png��6   5>      �� 5C      �� 5D      -   5        $��cmbFontFamily��5D   )    �� 
IsSelected . $	��150��6>   6J   �� 5E      -   5        $��	colorFont��5E      $	��100��6(   .@�5F      �� .��5G      �� $��Black��6    6/   5H      �� 5I      .��5J      �� $��Orange��6    60   5K      �� 5L      .��5M      �� $
��Pink��6    6.   5N      �� 5O      .��5P      �� $
��Blue��6    6.   5Q      5R      �� 5T      -   5        $��sldrFontSize��5T      $��20��6)   $��Center=�65   $	��100��6P    � Minimum$ 10Q�6\   	 � Maximum$	 50Q�6i   6v   �� 5U      -   5        $��interfaceLanguage��5U      $��47��60   
 �� SelectedIndex$
 1��6;   $��12(�6M   .@�5V      ��En��6$   ��5W      
Рус��6%   5X      �� 5Y      -   5        $��selectedTheme��5Y      $	��100��6-   $
 0��6[   .@�5Z      �� -   5        $��Theme1��5Z      $��Розовая��6-   �� 5[      -   5        $��Theme2��5[      $��Желтая��6-   �� 5\      -   5        $��Theme3��5\      $��Зеленая��6-   5]      5^      �� 5_   
   $��2��6   .@�5`      �� .��5a      �� $��Кол-во слов:��6   5b      �� 5c      .��5d      �� -   5        $��lblCursorPosition��5d      5e      �� 5f      $��Right=�6   .��5g      �� -   5         ��Name$ grayColorCheckBox��5g      $7��1Серый фон печатной области��68   5h      5i      �� 5j   
   -   5        $��	rtbEditor��5j       J� 	AllowDrop . $��1��6f   $��Stretch=�6s   $��Stretch=�6�   $��10,20,9.6,0q�6�   ��5k      �� 5l       �� Triggers 5m      �� 5n       �� Binding 6&   ��  �� ElementName$ grayColorCheckBox�� �� Path$ 	IsChecked� �� Value true6n   .a�5o      ��  �� Property � �� �� Value
 �����6I   5p      5r      5t      5u      5v      