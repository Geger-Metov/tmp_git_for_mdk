   M S B A M L   `   `   `  ����G  CCinemaPoster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CinemaPosterCinemaPoster  5   	       CinemaPoster.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CinemaPoster     5   	     � Title$  Киноафиша��5   	   $	��600��6   $	��800��6(   ���	#FF1C1C1C.��5	      �� .��5
   
   �� $��20q�6   .+�5      �� $��Киноафиша��6   $��36(�6)   $
��Bold"�67   
�������$��Center=�6\   $��0,0,0,20q�6y   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,0,0,20q�6O   .+�5      �� -   5         ��Name$ SearchTextBox��5      $	��300��61   $��30��6=   
���   �6J   �� 5      -   5         ��Name$ SearchButton��5      $��
Поиск��6/   $��80��6?   $��30��6J   6V   5      �� 5      -   5        $��MoviesItemsControl��5      ��5      �� 5      .R�5      � 5      ��5      �� 5      .R�5      �� $��10q�6!   ���	#FF2E2E2E �� CornerRadius$ 10��6D    �� Padding$ 10q�6V   $	��200��6c   ._�5      �� .+�5   "   �� $	��180��6E   $	��250��6Q   $��UniformToFill=�6^   $��0,0,0,10q�6v   ��6(   �� *	PosterUrl+6v   �� 5   "   $��18(�6C   $
��Bold"�6Q   
���������6,   �� *Title+6c   �� 5   "   $��14(�6C   
���������6,   �� *Genre+6Q   �� 5   "   $��12(�6I   
�������$
��Wrap=�6i   ��6,   �� *Description+6i   5       5!      5"      5$      5%      5&      5'      