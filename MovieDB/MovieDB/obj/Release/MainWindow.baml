   M S B A M L   `   `   `  ���� B  >MovieDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MovieDBMovieDB      MovieDB.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MovieDB     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  MovieDB��$	��650��$
��1000�� � WindowStartupLocation$ CenterScreen=�$��Century Gothic)�$��5(�.���  � RowDefinitions �� $��* ��� $��9* �.+�� $��0�� � ColumnDefinitions �� $
��1.5* ��� $��3* ��� $
��1.5* �.+��� $��0�� �� Orientation$ 
Horizontal=�$
��Left=�$��Center=�$��20 0 0 0q�.+��� -    ��Name$ 	cb_Search��$y�Hidden=�$��0��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�$��27��$��27��$��2 5 0 0q��� -    ��Name$ 
txt_Search�� �� 	MaxLength$ 30��$��18(�$	��200��$��27���� $��1��$��MovieDB��$��Center=�$��Center=�$��15(�$
��Bold"�
���   ��� $��2��$ 
Horizontal=�$��Right=�$��Center=�$��0 0 10 0q�.+��� -   $ cb_Alert��$y�Hidden=�$��0���� -   
���   �
������ 
������ $��0q�	 � Cursor$
	 Hand��.��  $ QuestionMarkCircleOutline=�$��30��$��30���� -   
���   �
������ 
������ $��0q�$��25 0 0 0q�$��50��$��50��$
	 Hand��.��%  MaterialDesignThemes.Wpf.Badged  -   
  Name$
 	md_Badged��  ControlzEx.BadgedEx   Badge$ 0��.��  $ BellRingOutline=�$��30��$��30���� -   
���   �
������ 
������ $��0q�$��	25 0 20 0q�$
	 Hand��.��  $
 Menu=�$��30��$��30�� � -     �Name$ 	MainFrame��$��1��  � NavigationUIVisibility$ Hidden=�