   M S B A M L   `   `   `  ����B  >MovieDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MovieDBMovieDB  5   	       MovieDB.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MovieDB     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MovieDB��5	   	   $	��650��6   $
��1000��6&    � Icon$ /resources/icon/icon5.png��63    � WindowStartupLocation$ CenterScreen=�6T   $��Century Gothic)�6y   $��5(�6�   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��9* �6   .+�5   
   � $��0��6      gd_HeaderColor#���   6    � ColumnDefinitions 5      �� 5      $
��1.5* �6#   �� 5      $��3* �6#   �� 5      $
��1.5* �6#   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   $
��Left=�6B   $��Center=�6]   $��20 0 0 0q�6x   .+�5      �� -   5         ��Name$ 	cb_Search��5      $y�Hidden=�6/   $��0��6D   
�������6a   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Search=�6*   $��27��68   $��27��6C   $��2 5 0 0q�6O     icn_ColorStyle#���  6a   �� 5      -   5         ��Name$ 
txt_Search��5      	 �� 	MaxLength$	 30��6.   $��18(�6=   $	��200��6K   $��27��6W   
������ .  (MaterialDesignThemes.Wpf.ScrollBarAssist
   ButtonsVisibility$
 Hidden=�6�   5      �� 5        lbl_MovieDB#���  6   $��1��6:   $��MovieDB��6J   $��Center=�6\   $��Center=�6w   �� 5!      $��2��6   $ 
Horizontal=�6)   $��Right=�6B   $��Center=�6^   $��0 0 10 0q�6y   .+�5"      �� -   5        $ cb_Alert��5"      $y�Hidden=�6-   $��0��6A   6K   �� 5#      -   5        
���   �
������ 
������ $��0q�5#   a    � Cursor$
 Hand��6m   .��5$        $ QuestionMarkCircleOutline=�6.   $��30��6O   $��30��6Z   #���  6f   5%      �� 5&      -   5        
���   �
������ 
������ $��0q�5&   `   $��25 0 0 0q�6l   $��50��6~   $��50��6�   $
 Hand��6�   .��5'      %  MaterialDesignThemes.Wpf.Badged  -   5          Name$ 	md_Badged��5'   ,     ControlzEx.BadgedEx   Badge$ 0��6?   .��5(        $ BellRingOutline=�62   $��30��6K   $��30��6V   #���  6b   5)      5*      �� 5+      -   5        
���   �
������ 
������ $��0q�5+   a   $��	25 0 20 0q�6m   $
 Hand��6�   .��5,        $
 Menu=�6.   $��30��6:   $��30��6E   #���  6Q   5-      5.      5/       � 51   
   -   5          �Name$ 	MainFrame��51      $��1��6#     � NavigationUIVisibility$ Hidden=�60   52      53      