   M S B A M L   `   `   `  ����W  SPRN212Assignment01_WPF _LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PRN212Assignment01_WPF__LINQPRN212Assignment01_WPF__LINQ  5   	   2    ,PRN212Assignment01_WPF__LINQ.CustomerBooking   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:PRN212Assignment01_WPF__LINQ     5   	   -   5          � Title$  CustomerBooking��5   	   $	��450��6!   $	��800��6.   
����� �.��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��0��6   .+�5      �� -   5        $��btnBack��5   ?   $
��40px��6   $
��30px��6"   $
��Back��60   6f   5      �� 5   
   $��1��6   .+�5      �� $��30(�6   $��Booking��6"   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��70��6   $��Start Date:��6#   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpkStartDate��5      $	��200��63   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��70��6   $��	End Date:��6#     5      -   5        $ 
dpkEndDate��5      $	��200��61   5       �� 5"      $ 
Horizontal=�6   .+�5#      �� $��70��6   $��
Room Type:��6#   �� 5$      -   5         ��Name$ cbxRoomType��5$      $	��200��60    �� SelectedValue 6<   �� *$"SelectedItem.RoomType.RoomTypeName+ �� ElementName$ 
dgvDisplay�� �� Mode$ OneWay=�6�   5%      �� 5'      $ 
Horizontal=�6   .+�5(      �� $��70��6   .��6#   Room Number:61   �� 5)      -   5        $��cbxRoomNumber��5)      $	��200��60    6<   �� $ 
dgvDisplay�� �� Path$" SelectedItem.Room.RoomNumber�$ OneWay=�6�   5*      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��70��6   $��Total Price��6#   �� 5/      -   5        	 ��Name$	 txtTotalPrice��5/      $	��200��61   
 �� 
IsReadOnly$

 True��6=   50      �� 52      -   5         ��Name$ 	btnInsert��52      $��Booking��6(   $	��100��6R   $��30��6^   $��Center=�6j   $
��0 10q�6�   54      55      56      