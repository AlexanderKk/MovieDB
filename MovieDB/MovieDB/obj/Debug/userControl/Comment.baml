   M S B A M L   `   `   `  ����B  >MovieDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MovieDB.userControlMovieDB.userControl  5      !    MovieDB.userControl.Comment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:MovieDB.userControl     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $	��300��6   .+�5   
   ��   �� CornerRadius$  5��6   
�������$��0��65   ._�5      �  � RowDefinitions 5      �� 5      $	��29* �6$   �� 5      $	��71* �6$   .+�5      �  � ColumnDefinitions 5      �� 5      $	��62* �6+   �� 5      $	��65* �6+   �� 5      $	��23* �6+   .+�5      � $��0��6   .+�5      �� -   5         ��Name$ lbl_username��5       
���   �$�� ��6I   $��11(�6T   $
��Left=�6b   $��8 0 0 0q�6}   5      � 5      $��1��6   .+�5      �� -   5        $ lbl_data��5       
���   �$�� ��6E   $��11(�6P   $��Right=�6^   $��8 0 8 0q�6z   5      � 5      $��2��6   .+�5      ��  �� Orientation$ 
Horizontal=�6%   $��Right=�6>   $��0 8 5 0q�6Z   .+�5       �� -   5         ��Name$ edit_comment��5    4    � ToolTip$
 edit��6%   $��0q�6d   $��20��6p   $��20��6{   $��0 0 3 0q�6�   
�������$��0q�6�   .��5!   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Edit=�6:   ���#f2beb8$��15��6[   $��15��6f   5"      5#      5%      5&      � 5(      $��1��6   .+�5)      �� -   5         ��Name$ txt_comment��5)      
���   �$�� ��6G   	 �� TextWrapping$
	 Wrap=�6O   $��12(�6c   $��7q�6q   $��2��6|   
 �� 
IsReadOnly
 . 6�   5*      5,      5-      5.      5/      