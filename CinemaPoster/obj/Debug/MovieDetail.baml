   M S B A M L   `   `   `  ����G  CCinemaPoster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CinemaPosterCinemaPoster  5   	       CinemaPoster.MovieDetail   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CinemaPoster     5   	     � Title$*  $Информация о фильме��5   	   $	��450��6%   $	��800��62   ���	#FF1C1C1C.��5
      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��MoviePoster��5      $	��200��6#   $	��300��6/   $��Uniform=�6<   $��0,0,10,0q�6N   $��0��6`   �� 5   
   $��1��6   .+�5      �� -   5        $��
MovieTitle��5      $��24(�6*   $
��Bold"�68   
�������6J   �� 5      -   5        $��
MovieGenre��5      $��16(�6*   
�������68   �� 5      -   5        $��MovieDescription��5      $��14(�60   
�������$
��Wrap=�6P   $��	0,10,0,10q�6d   �� 5      -   5        $��MovieDirector��5      $��14(�6-   
�������6;   �� 5      -   5        $��MovieActors��5      $��14(�6+   
�������69   �� 5      $*��$Расписание сеансов:��6   $��16(�63   $
��Bold"�6A   
�������$��	0,20,0,10q�6f   �� 5      -   5        $��ShowtimesItemsControl��5      ��5      �� 5      .R�5      �� 5      ��5       �� 5!      .R�5"      �� $��14(�65   
���������6$   �� 6C   5#      5%      5&      5'      5(      