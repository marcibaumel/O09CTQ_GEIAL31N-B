   M S B A M L   `   `   `  ���� G  CNextFilm.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NextFilm.WPF.PagesNextFilm.WPF.Pages  !    NextFilm.WPF.Pages.FilmList   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:NextFilm.WPF.Pages       N� Title$  FilmList��.��� $��0q�.+���  �� Orientation$ 
Horizontal=�$��30��$	��Top=�.+��� -    ��Name$ WelcomeLabel���� -    ��Name$ btnLogut��$��Logout��$	��100��$��	550,5,0,0q�
��� ��� � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� $ 
Horizontal=�$��35��$��Bottom=�.+��� -   $ showAddFilmBtn��$��Add Film��$	��100��$��	650,0,0,5q�$��Center=� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� -   $ showHistory��$��History��$	��100��$��
-400,0,0,5q�$��Center=� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� -    ��Name$ addFilmPanel��$��156,20,156,40q����#EBEBEB$y�Hidden=�.+��� $��	Add Film:��$��46��$��20(�$
��Bold"��� $��Film Title:��$��	10,0,10,0q��� -   	 ��Name$	 filmTitleInput��
 �� TextWrapping$

 Wrap=�$	��478��$��35��$��	10,0,10,0q��� $��
Film Year:��$��29��$��
10,20,10,0q��� -   $	 filmYearInput��$

 Wrap=�$	��480��$��39��$��	10,0,10,0q��� -   $ BtnClcikAddFilm��$	��Add��$��42��$��
50,60,50,0q� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� -	   $ filmList��$��
0,49,28,61q�.+��� -
   $��FilmBinding��$��10q�$
��True��$	��235��$	��700��$��0q����� .R�� $��Center=�$��Center=�$��0q�$	��100�� � ColumnDefinitions �� $	��250 ��� $��50 ��� $
��auto ��� $��50 ��� $	��100 ��� $	��100 �.+��� $	��100��$��0������ *Poster+�� $��Name: ��$��1���� $
��Bold"�$��2������ *Title+�� -   $��4��$��Watched��$��60��$��60��
���"�"�{���  �� Path$ 
IsSelected� �� RelativeSource �� *FindAncestor+ �� AncestorType" �� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� -   $��5��$��Delete��$��60��$��60��
����p��{��� $ 
IsSelected� �� *FindAncestor+" �� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� -   $ historyList��$��10,49,28,61q�
�������.+��� -   $��FilmHistoryBinding��$��10q�$
��True��$	��235��$	��700��$��0q����� .R�� $��Center=�$��Center=�$��0q�$	��100�� �� $	��250 ��� $��50 ��� $
��auto ��� $��50 ��� $	��120 ��� $	��100 �.+��� $	��100��$��0������ *Poster+�� $��Name: ��$��1���� $
��Bold"�$��2������ *Title+�� -   $��4��$��	Unwatched��$��60��$��70��
�������{��� $ 
IsSelected� �� *FindAncestor+" �� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5���� -   $��5��$��Delete��$��60��$��60��
����p��{��� $ 
IsSelected� �� *FindAncestor+" �� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5��