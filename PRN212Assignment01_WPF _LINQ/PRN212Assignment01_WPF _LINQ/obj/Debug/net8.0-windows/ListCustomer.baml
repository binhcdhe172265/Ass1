   M S B A M L   `   `   `  ����W  SPRN212Assignment01_WPF _LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PRN212Assignment01_WPF__LINQPRN212Assignment01_WPF__LINQ  5   	   /    )PRN212Assignment01_WPF__LINQ.ListCustomer   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:PRN212Assignment01_WPF__LINQ     5   	   
����� �.��5	      � $��10,45,10,99q�6     � ColumnDefinitions  5
   
   �� 5      $��4* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dvgDisplay��5   #   $��0��6      AutoGenerateColumns$ False��65      CanUserAddRows$ False��6Q   $��	0,0,0,-73q�6h      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
CustomerId+ �� Mode$ OneWay=�  5      $ * 6%   $ FullName��6/    6A   �� *CustomerFullName+$ OneWay=�  5      $ * 6%   $ 	Telephone��6/    6B   �� *	Telephone+$ OneWay=�  5      $ * 6%   $ Email��6/    6>   �� *EmailAddress+$ OneWay=�  5      $ * 6%   $	 DOB��6/    6<   �� *CustomerBirthday+$ OneWay=�  5      $ * 6%   $ Status��6/    6?   �� *CustomerStatus+$ OneWay=�  5      $ * 6%   $ Password��6/    6A   �� *
Password+$ OneWay=�5      �� 5   
   $��1��6   $��	0,0,0,-73q�6%   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5      �� $��50��6   .��6#   Id6'   �� 5      -   5        $��txtId��5      $	��200��6'   ��63   �� 	 �� ElementName$	 
dvgDisplay��
 �� Path$
 SelectedItem.CustomerId�$ OneWay=�5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5       �� $��50��6   .��6#   Name6)   �� 5!      -   5        $��txtName��5!      $	��200��6)   ��65   �� $	 
dvgDisplay��$#
 SelectedItem.CustomerFullName�$ OneWay=�5"      �� 5#      $ 
Horizontal=�6   $��5q�62   .+�5$      �� $��50��6   .��6#   Phone6*   �� 5%      -   5        $��txtPhone��5%      $	��200��6*   ��66   �� $	 
dvgDisplay��$
 SelectedItem.Telephone�$ OneWay=�5&      �� 5'      $ 
Horizontal=�6   $��5q�62   .+�5(      �� $��50��6   .��6#   Email6*   �� 5)      -   5        $��txtEmail��5)      $	��200��6*   ��66   �� $	 
dvgDisplay��$
 SelectedItem.EmailAddress�$ OneWay=�5*      �� 5+      $ 
Horizontal=�6   $��5q�62   .+�5,      �� $��50��6   .��6#   DOB6(   �� 5-      -   5        $��dpkDob��5-      $	��200��6(   ��64   �� $	 
dvgDisplay��$#
 SelectedItem.CustomerBirthday�$ OneWay=�5.      �� 5/      $ 
Horizontal=�6   $��5q�62   .+�50      �� $��50��6   .��6#   Status6+   �� 51      -   5        $��	txtStatus��51      $	��200��6+   ��67   �� $	 
dvgDisplay��$!
 SelectedItem.CustomerStatus�$ OneWay=�52      �� 53      $ 
Horizontal=�6   $��5q�62   .+�54      �� $��50��6   .��6#   Pass6)   �� 55      -   5        $��txtPassword��55      $	��200��6-   ��69   �� $	 
dvgDisplay��$
 SelectedItem.Password�$ OneWay=�56      �� 57      $ 
Horizontal=�6   $��Center=�62   $��5q�6O   .+�58      �� -	   5        $��Insert��58      $��5q�6*   65   �� 59      -
   5        $��Update��59      $��5q�6*   65   �� 5:      -   5        $��Delete��5:      $��5q�6*   65   5;      5<      5=      5>      