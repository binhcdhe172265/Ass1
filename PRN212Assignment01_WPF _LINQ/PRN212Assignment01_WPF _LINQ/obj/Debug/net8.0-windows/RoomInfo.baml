   M S B A M L   `   `   `  ����W  SPRN212Assignment01_WPF _LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PRN212Assignment01_WPF__LINQPRN212Assignment01_WPF__LINQ  5   	   +    %PRN212Assignment01_WPF__LINQ.RoomInfo   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:PRN212Assignment01_WPF__LINQ     5   	   
����� �.��5
      � $��10,45,10,99q�6     � ColumnDefinitions  5   
   �� 5      $��3* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dvgDisplay��5   #   $��0��6      AutoGenerateColumns$ False��65      CanUserAddRows$ False��6Q      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *RoomId+ �� Mode$ OneWay=�  5      $ * 6%   $ 
RoomNumber��6/    6C   �� *
RoomNumber+$ OneWay=�  5      $ * 6%   $ Detail��6/    6?   �� *RoomDetailDescription+$ OneWay=�  5      $ * 6%   $ RoomMaxCapacity��6/    6H   �� *RoomMaxCapacity+$ OneWay=�  5      $ * 6%   $ 
RoomTypeId��6/    6C   �� *
RoomTypeId+$ OneWay=�  5      $ * 6%   $ Status��6/    6?   �� *
RoomStatus+$ OneWay=�  5      $ * 6%   $ Price��6/    6>   �� *RoomPricePerDay+$ OneWay=�5      �� 5   
   $��1��6   $��0,10,-75,-83q�6%   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5      �� $��50��6   .��6#   Id6'   �� 5      -   5        $��txtId��5   ,   $��30,0,0,0q�6   $	��192��69   ��6E   �� 	 �� ElementName$	 
dvgDisplay��
 �� Path$
 SelectedItem.RoomId�$ OneWay=�5      �� 5       $ 
Horizontal=�6   $��5q�62   .+�5!      �� $��50��6   .��6#   Number6+   �� 5"      -   5        $��	txtNumber��5"   ,   $��30,0,0,0q�6   $	��192��6=   ��6I   �� $	 
dvgDisplay��$
 SelectedItem.RoomNumber�$ OneWay=�5#      �� 5$      $ 
Horizontal=�6   $��5q�62   .+�5%      �� $��50��6   .��6#   Detail6+   �� 5&      -   5         ��Name$ 	txtDetail��5&   ,   $��30,0,0,0q�6   $	��192��6?   ��6K   �� *$"SelectedItem.RoomDetailDescription+$	 
dvgDisplay��$ OneWay=�5'      �� 5(      $ 
Horizontal=�6   $��5q�62   .+�5)      �� $��50��6   .��6#   MaxCapacity60   �� 5*      -   5        $��txtMaxCapacity��5*   ,   $��30,0,0,0q�6   $	��192��6B   ��6N   �� $	 
dvgDisplay��$"
 SelectedItem.RoomMaxCapacity�$ OneWay=�5+      �� 5,      $ 
Horizontal=�6   $��5q�62   .+�5-      �� $��50��6   .��6#   
RoomTypeId6/   �� 5.      -   5        $ txtRoomTypeId��5.   ,   $��30,0,0,0q�6   $	��192��6C   ��6O   �� *SelectedItem.RoomTypeId+$	 
dvgDisplay��$ OneWay=�5/      �� 50      $ 
Horizontal=�6   $��5q�62   .+�51      �� $��50��6   .��6#   Status6+   �� 52      -   5        $��	txtStatus��52   ,   $��30,0,0,0q�6   $	��192��6=   ��6I   �� $	 
dvgDisplay��$
 SelectedItem.RoomStatus�$ OneWay=�53      �� 54      $ 
Horizontal=�6   $��5q�62   .+�55      �� $��50��6   .��6#   Price6*   �� 56      -   5        $ txtPrice��56   ,   $��30,0,0,0q�6   $	��192��6>    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6J   �� *SelectedItem.RoomPricePerDay+$	 
dvgDisplay��$ OneWay=�.��6�   z�57      V� 58      .~�59      �� �� 5:      �� 5;       �� Angle$ 0.296Q�6.   T� 5<      5=      .��5>   /   5?      5@      �� 5A      $ 
Horizontal=�6   $��5q�62   .+�5B      �� -	   5        $��Insert��5B      $��10q�6*   $��53��6Q   �� 5C      -
   5        $��Update��5C      $��10q�6*   66   �� 5D      -   5        $��Delete��5D      $��10q�6*   66   5E      5F      5G      5H      