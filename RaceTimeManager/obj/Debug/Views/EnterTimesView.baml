   M S B A M L   `   `   `  ����J  FRaceTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RaceTimeManager.ViewsRaceTimeManager.Views  5      *    $RaceTimeManager.Views.EnterTimesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:RaceTimeManager.Views     5      .��5	      ��   �� SelectedIndex  6   �� *TabViewSelectedIndex+.@�5
   
   �� $y�	Collapsed=�6   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��1��6g   $��1��6w   $��Center=�6�   $	��200��6�   ��6   �� *
RaceList+  6;   �� *RaceSelectedIndex+��5      �� 5      .R�5      �� ��6$   �� *
RaceName+5      5      �� 5      $��Select Race��68   $��Center=�6N   $��Center=�6k   $	��100��6�   ��6   �� *
SelectRace+6�   5      5      �� 5   
   $y�	Collapsed=�6   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5       $
��Auto �6'   �� 5!      $
��Auto �6'   �� 5"      $
��Auto �6'   �� 5#      $
��Auto �6'   .+�5%      �� $��0��6   $��0��6&   $��	Main Menu��66   $
��Left=�6J   $	��Top=�6e   $��75��6}   ��6�   �� *
MainMenu+�� 5&      $��Bib Number:��6   $��1��6.   $��0��6;   �� 5'      $��1��6   $��1��6*   $
��Left=�6R   $��23��6m    �� TextWrapping$
 Wrap=�6y   $	��Top=�6�   $	��120��6�   ��67   �� *	BibNumber+6�   �� 5(      $��2��6   $��1��6&   $��
Start Time��6T   $
��Left=�6i   $	��Top=�6�   $��75��6�   ��66   �� *	StartTime+6�   �� 5)      $��2��6   $��2��6&   $��Finish Time��6U   $
��Left=�6k   $	��Top=�6�   $��75��6�   ��66   �� *
FinishTime+6�   �� 5*      $��Split Distance:��6   $��3��62   $��0��6?   �� 5+      $��3��6   $��1��6'   $
��Left=�67   $��23��6R   $
 Wrap=�6^   $	��Top=�6�   $	��120��6�   ��6r   �� *SplitDistance+6�   �� 5,      $��3��6   $��2��6(   $
��Left=�68   $��23��6T   $	��Top=�6`   $��60��6x   ��6�   �� *	UnitTypes+ �� SelectedItem 6�   �� *
SplitUnits+�� 5-      $��3��6   $��3��6&   $��	Add Split��6S   $
��Left=�6g   $	��Top=�6�   $��75��6�   ��66   �� *
AddSplit+6�   5.      5/      50      51      