   M S B A M L   `   `   `  ����J  FRaceTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RaceTimeManager.ViewsRaceTimeManager.Views  5      (    "RaceTimeManager.Views.RegisterView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:RaceTimeManager.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��	Main Menu��6.   $
��Left=�6B   $	��Top=�6]   $��75��6u   ��6�   �� *
MainMenu+�� 5   
   $��1��6   $��0��6   $��Center=�6-   $��Runners��6J   �� 5   
   $��1��6   $��1��6   $��Center=�6-   $��Races��6J   �� 5   
   $��0��6e   $��2��6u   $��Center=�6�   $	��200��6�   ��6   �� *RunnersList+ �� SelectedIndex 66   �� *RunnersSelectedIndex+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6    �� *	FirstName+�� 5      ��6    �� *
LastName+5      5      5!      �� 5"   
   $��1��6_   $��2��6o   $��Center=�6|   $	��200��6�   ��6   �� *
RaceList+ 63   �� *RaceSelectedIndex+��5#      �� 5$      .R�5%      �� ��6   �� *
RaceName+5&      5(      �� 5)   
   $��2��6   $��2��6   $��Register Runner��6Q   $��Center=�6k   $	��Top=�6�   $	��100��6�   ��6.   �� *RegisterRunner+6�   5+      5,      