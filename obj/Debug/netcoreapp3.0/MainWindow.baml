   M S B A M L   `   `   `  ����H  DCalculatrice2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Calculatrice2Calculatrice2  5   	       Calculatrice2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Calculatrice2     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType   	borderTop �� Property �� Value 	 title��%g  &	        '�� m     &	 �     �� 5
   
   " ��6   .�5      ��  � ��
 �   �6,   �� 5       � ��$ 2q�60   5      �� 5   
   " ��6   .�5      ��  � ��$ 25(�6)   �� 5       � ��
 �����6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 25(�6)   �� 5       � ��
 �����6+   5      5      .��5      � $��Center=�6   $��Center=�6&    � ShowGridLines$ False��6C   $	��450��6Y   $	��400��6e    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5!   
   �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      .+�5,   
   �� #��[  6   $��4��64   $��0��6H   ._�5-      �� #��[ 6   
���OO/�$��Right=�6j   $��Center=�6�   ��67   �� *Result+6�   5.      �� 5/   
   -   5        $��4��5/      $��0��6%   $��6��65   
���OO/�.��50      �� CE6   51      �� 52   
   -   5        $��0��52      $��5��6!   
���OO/�.��53      �� √6   54      �� 55   
   -   5        $��1��55      $��5��6!   
���OO/�.��56      �� ^6   57      �� 58   
   -   5        $��1��58      $��5��6%   $��2��62   
���OO/�.��59      �� (6   5:      �� 5;   
   -   5        $��1��5;      $��5��6&   $��3��63   
���OO/�.��5<      �� )6   5=      �� 5>   
   #��[  6   $��2��64   $��0��6H   $��4��6U   ._�5?      �� #��[ 6   $��Center=�67   $��Center=�6T   
���OO/�
Historique6�   5@      �� 5A   
   $��2��66   $��6��6J   $��4��6[   $��1��6k   
���������6   �� *Historiques+��5B      �� 5C      .R�5D      ��  �� Orientation$ Vertical=�6!   .+�5F      �� $ 
Horizontal=�6%   .+�5G      �� ��6(   �� *CalculHisto+�� 5H      $	�� = ��6(   5I      �� 5K      $ 
Horizontal=�6%   .+�5L      �� ��6(   �� *ResultatHisto+5M      5N      5O      5Q      �� 5R   
   -   5        $��1��5R      $��0��6   .��5S      �� 16   5T      �� 5U   
   -   5        $��1��5U      $��1��6   .��5V      �� 26   5W      �� 5X   
   -	   5        $��1��5X      $��2��6   .��5Y      �� 36   5Z      �� 5[   
   -
   5        $��1��5[      $��3��6   
���iii�.��5\      �� /6   5]      �� 5^   
   -   5        $��2��5^      $��0��6   .��5_      �� 46   5`      �� 5a   
   -   5        $��2��5a      $��1��6   .��5b      �� 56   5c      �� 5d   
   -   5        $��2��5d      $��2��6   .��5e      �� 66   5f      �� 5g   
   -   5        $��2��5g      $��3��6   
���iii�.��5h      �� *6   5i      �� 5j   
   -   5        $��3��5j      $��0��6   .��5k      �� 76   5l      �� 5m   
   -   5        $��3��5m      $��1��6   .��5n      �� 86   5o      �� 5p   
   -   5        $��3��5p      $��2��6   .��5q      �� 96   5r      �� 5s   
   -   5        $��3��5s      $��3��6   
���iii�.��5t      �� +6   5u      �� 5v   
   -   5        $��4��5v      $��0��6   .��5w      �� 06   5x      �� 5y   
   -   5        $��4��5y      $��1��6   .��5z      �� ,6   5{      �� 5|   
   -   5        $��4��5|      $��2��6   
��� � �.��5}      �� =6   5~      �� 5   
   -   5        $��4��5      $��3��6   
���iii�.��5�      �� -6   5�      5�      5�      