   M S B A M L   `   `   `  ����   RaceTimeManager)    #RaceTimeManager.Views.AddRunnerView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .���   � RowDefinitions  �� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -    ��Name$ runnerFirstName��$��0��$��0��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��1,1,0,0q����� *	FirstName+ �� Mode$ OneWayToSource=��� -   $ runnerLastName��$��0��$��1��$
��Left=�$��23��$
 Wrap=�$	��Top=�$	��120������ *
LastName+$ OneWayToSource=��� -   $ 	runnerDOB��$��0��$��2��$
��Left=�$��23��$
 Wrap=�$	��Top=�$	��120������ *DateOfBirth+$ OneWayToSource=��� -    ��Name$ AddRunnerButton��$��1��$��0��$��
Add Runner��$
��Left=�$	��Top=�$��75������ *DisplayAddRunerView+