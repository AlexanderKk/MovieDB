   M S B A M L   `   `   `  ���� B  >MovieDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MovieDB.pagesMovieDB.pages      MovieDB.pages.MainPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  'localclr-namespace:MovieDB.pages    N� Title$  ProfilePage��.���  � RowDefinitions �� $��* ��� $��4* �.+�� $��0�����#14752f � ColumnDefinitions �� $
��1.2* ��� $
��0.7* ��� $
��1.2* �.+��� -    ��Name$ btn_Edit��$��Edit Profile��$��1��$��Center=�$��Center=�$��25(�
��������� -   $ btn_Statistics��$��Staticstics��$��2��$��Center=�$��Center=�$��25(�
�������� $��1�����#76cc8e$��	0,0,0,-20q� �� $
��298* ��� $
��223* ��� $
��279* �.+���  � ToolTip$ Change photo��$��0��
������ $��0q�$��73,-50,46,0q�$	��150��$	��Top=�.��A� $	��150��$	��150��$	��-36q�
�������$��3�� �� StrokeDashArray$ 1 R� �� StrokeDashCap$ Round=����� -   img_ProfilePhoto�� �� ImageSource$" /resources/profile/photo.jpg�� j� Stretch$ UniformToFill=�	 j� 
AlignmentX$	 Center=�
 j� 
AlignmentY$
 Center=��� $��50��$��50��$��
0 50 10 0 q����#b1ccb9$��Right=�$	��Top=�$��15(�
���   �.���� $
��Wrap=�$��15(�$��50��$��50��$��-19 1q� �� TextAlignment$ Center=�	New photo�� $��0��$��30,100,5,20q�.+��  �� $��70 ��� $��60 ��� $��60 ��� $��60 �.+��� $��0��.+��� -   $ UserName��$��Surname and username��$��20(�$��Italic$�$��DemiBold"�$��Center=�
��������� -   $ ProfLoc��$!��Add into and edit settings.��$��Center=�$��Bottom=�$��21��$
��bold"�
�������$
��44,0q��� $��1��.+��� $��Email��$��10 0 0 0q�$��15(��  �� $��7* ��� $��2* �.+��� -    ��Name$ 	lbl_Email��$��0�� �� 
IsReadOnly . 
���   �$��0 3 10 3q�$��
your email���� -    ��Name$ btn_EditEmail��$��1��$ Change mail��
������ 
���   �$��50��$��30��
���   �$��1q�.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Edit=�$��20��$��20��
��������� $��2��.+��� $��Phone��$��10 0 0 0q�$��15(�$��25���  �� $��7* ��� $��2* �.+��� -   $ 
lbl_Emaild��$��0�� . 
���   �$��0 3 10 3q�$��
your phone���� -	   $ btn_EditEmdail��$��1��$ Change mail��
������ 
���   �$��50��$��30��
���   �$��1q�.��  $
 Edit=�$��20��$��20��
��������� $��3��.+��� $��Contacts��$��10 0 0 0q�$��15(�$��25���  �� $��7* ��� $��2* �.+��� -
   $ lbl_Efmaild��$��0�� . 
���   �$��0 3 10 3q�$��your contact���� -   $ btn_EditPhone��$��1��$ Change mail��
������ 
���   �$��50��$��30��
���   �$��1q�.��  $
 Edit=�$��20��$��20��
��������� $��1��$��20 30 20 30q�.+��  �� $	��170 ��� $	��150 ��� $	��100 �.+��� $��0��.+��� $��Change Theme��$��Center=�$��Center=�$��15(��� -    ��Name$ 	cb_Themes��
�������$��16(��� $��Change Language��$��Center=�$��Center=�$��15(�$��0 15 0 0q��� -   $ cb_Langs��
�������$��16(��� $��1��.+��� $��Description��$��16(�$��Center=��� -   $ tb_Desc��$
��0 10q� �� 	MaxLength$ 30��
�������$��16(�$��30���� -    ��Name$ sp_Statistics��$��2��