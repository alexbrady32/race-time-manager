   M S B A M L   `   `   `  ����J  FRaceTimeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RaceTimeManager.ViewsRaceTimeManager.Views  5      %    RaceTimeManager.Views.RacesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:RaceTimeManager.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��	Main Menu��6.   $
��Left=�6B   $	��Top=�6]   $��75��6u   ��6�   �� *
MainMenu+�� 5   
   $��	Race Name��6   $��1��6$   $��0��61   �� 5   
   $
��Date��6   $��1��6   $��1��6,   �� 5   
   $��Distance��6   $��1��6#   $��2��60   �� 5   
   -   5         ��Name$ raceName��5      $��2��6$   $��0��61   $
��Left=�6A   $��23��6\    �� TextWrapping$
 Wrap=�6h   $	��Top=�6�   $	��120��6�   ��6|   �� *
RaceName+6�   �� 5   
   -   5        $ raceDate��5      $��2��6$   $��1��61   $
��Left=�6A   $��23��6\   $
 Wrap=�6h   $	��Top=�6�   $	��120��6�   ��6|   �� *
RaceDate+6�   �� 5   
   -   5        $ raceDistance��5      $��2��6(   $��2��65   $
��Left=�6E   $��23��6`   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   ��6�   �� *RaceDistance+6�   �� 5   
   -   5         ��Name$ 	raceUnits��5      $��2��6&   $��3��63   $
��Left=�6C   $��23��6_   $	��Top=�6k   $��60��6�   ��6�   �� *	UnitTypes+ �� SelectedItem 6�   �� *	RaceUnits+�� 5    
   -   5         ��Name$ addRaceButton��5       $��3��6(   $��0��65   $��Add Race��6E   $
��Left=�6X   $	��Top=�6s   $��75��6�   ��6�   �� *	AddRace+&   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ raceList��5!      $��4��6%   $��0��62   $��3��6B      AutoGenerateColumns .  	   CanUserAddRows	 .  
   
IsReadOnly
 . ��6V   �� *
RaceList+   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5$      �� *ID+  5%      $
 Name��6%    5&      �� *
RaceName+  5'      $
 Date��6%    5(      �� *
RaceDate+ �� StringFormat$ {0:MM/dd/yyyy }��  5)      $ Distance��6%    5*      �� *
Distance+  5+      $ Units��6%    5,      �� *Units+5.      5/      50      