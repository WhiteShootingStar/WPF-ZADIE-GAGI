   M S B A M L   `   `   `  ����F  BDeansOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DeansOfficeDeansOffice  5   	       DeansOffice.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DeansOffice     5   	     � Title$  
DeanOffice��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��5 �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m� -   5        $��Close��5      5      5      m� 5      $
��Edit��6   m� 5      $��Modules��6   5      R� 5   
   -   5         R�Name$ PersonTypeTreeView��5      $��0��6/   $��0��6?   $��0q�6L   5       �� 5!   
   $��0��6   $��1��6%   $��5��65   6A   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ StudentsDataGrid��5"      $��0��6.   $��2��6<      AutoGenerateColumns .     Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	FirstName+6Y     5%      $ 	Last Name��6%    68   �� *
LastName+6W     5&      $ ID��6%    61   �� *	StudentId+6Q     5'      $ Status��6%    65   �� *Status+6R     5(      $
 Year��6%    63   �� *Year+6N     5)      $ Semestr��6%    66   �� *	Semestr+6T     5*      $ Specialization��6%    6=   �� *Specialization+6b     5+      $
 Info��6%    63   �� *Info+6N   5-      �� 5.   
   $��1��6   $��0��6"   $��3��62   	 �� Orientation$	 
Horizontal=�6F   $��10q�6_   .+�5/      �� .��6   
Semester6   �� 50      @�51      �� 52      
 �� 
IsSelected
 . .��66   Semestr 20196D   �� 53      .��6#   Semestr 201861   �� 54      .��6#   Semestr 201761   56      �� 57      .��6   Version 1.1.26#   58      59      5:      