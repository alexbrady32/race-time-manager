   M S B A M L   `   `   `  ����  RaceTimeManager)    #RaceTimeManager.Views.AddRunnerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .��5	      �   � RowDefinitions  5
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
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��	Main Menu��6.   $
��Left=�6B   $	��Top=�6]   $��75��6u   ��6�   �� *
MainMenu+�� 5   
   $��
First Name��6   $��1��6%   $��0��62   �� 5   
   $��	Last Name��6   $��1��6$   $��1��61   �� 5   
   $	��DOB��6   $��1��6   $��2��6+   �� 5   
   -   5         ��Name$ runnerFirstName��5      $��2��6+   $��0��68   $
��Left=�6H   $��23��6c    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��120��6�   ��6�   �� *	FirstName+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ runnerLastName��5      $��2��6*   $��1��67   $
��Left=�6G   $��23��6b   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   ��6�   �� *
LastName+6�   �� 5   
   -   5        $ 	runnerDOB��5      $��2��6%   $��2��62   $
��Left=�6B   $��23��6]   $
 Wrap=�6i   $	��Top=�6�   $	��120��6�   ��6}   �� *DateOfBirth+6�   �� 5   
   -   5         ��Name$ addRunnerButton��5      $��3��6*   $��0��67   $��
Add Runner��6G   $
��Left=�6\   $	��Top=�6w   $��75��6�   ��6�   �� *	AddRunner+&   System.Windows.Controls.DataGrid  5   
   -   5          Name$ runnersList��5      $��4��6(   $��0��65   $��3��6E      AutoGenerateColumns .     CanUserAddRows .  	   
IsReadOnly	 . ��6Y   �� *
RunnerList+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5!      �� *ID+  5"      $ 
First Name��6%    5#      �� *	FirstName+  5$      $ 	Last Name��6%    5%      �� *
LastName+5'      5(      5)      