   M S B A M L   `   `   `  ����W  SPRN212Assignment01_WPF _LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PRN212Assignment01_WPF__LINQPRN212Assignment01_WPF__LINQ  5      0    *PRN212Assignment01_WPF__LINQ.BookingManage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:PRN212Assignment01_WPF__LINQ     5      
����� �.��5
      � $��0,95,119,20q�6     � ColumnDefinitions  5   
   �� 5      $��3* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dvgDisplay��5   #   $��0��6      AutoGenerateColumns$ False��65      CanUserAddRows$ False��6Q      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *BookingReservationId+ �� Mode$ OneWay=�  5      $ * 6%   $ BookingDate��6/    6D   �� *BookingDate+$ OneWay=�  5      $ * 6%   $ 
TotalPrice��6/    6C   �� *
TotalPrice+$ OneWay=�  5      $ * 6%   $ 
CustomerId��6/    6C   �� *
CustomerId+$ OneWay=�  5      $ * 6%   $ BookingStatus��6/    6F   �� *BookingStatus+$ OneWay=�5      �� 5   
   $��1��6   $��0,10,-75,-83q�6%   
����� �.+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5      �� $��50��6   .��6#   ID6'   �� 5      -   5        $��txtId��5   >   $��30,0,0,0q�6   	 �� 
IsReadOnly$
	 True��6,   $	��100��6K   ��6W   �� 
 �� ElementName$
 
dvgDisplay�� �� Path$' !SelectedItem.BookingReservationId�$ OneWay=�5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5       �� $��50��6   .��6#   Booking Date61   �� 5!      -   5        $��txtDate��5!   >   $��30,0,0,0q�6   $
	 True��6,   $	��100��6M   ��6Y   �� $
 
dvgDisplay��$ SelectedItem.BookingDate�$ OneWay=�5"      �� 5#      $ 
Horizontal=�6   $��5q�62   .+�5$      �� $��50��6   .��6#   Total Price60   �� 5%      -   5        $��txtPrice��5%   >   $��30,0,0,0q�6   $
	 True��6,   $	��100��6N   ��6Z   �� $
 
dvgDisplay��$ SelectedItem.TotalPrice�$ OneWay=�5&      �� 5'      $ 
Horizontal=�6   $��5q�62   .+�5(      �� $��50��6   .��6#   
CustomerID6/   �� 5)      -   5        $��txtCustomerId��5)   >   $��30,0,0,0q�6   $
	 True��6,   $	��100��6S   ��6_   �� $
 
dvgDisplay��$ SelectedItem.CustomerId�$ OneWay=�5*      �� 5,      $ 
Horizontal=�6   $��5q�62   .+�5-      �� $��50��6   .��6#   Status6+   �� 5.      -   5        $��	txtStatus��5.   ,   $��30,0,0,0q�6   $	��100��6=   ��6I   �� $
 
dvgDisplay��$  SelectedItem.BookingStatus�$ OneWay=�5/      �� 51      $ 
Horizontal=�6   $��5q�62   .+�52      �� -   5        $��Update��52      $��50,0,0,0q�6*   6<   53      54      55      57      