   M S B A M L   `   `   `  ����W  SPRN212Assignment01_WPF _LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PRN212Assignment01_WPF__LINQPRN212Assignment01_WPF__LINQ  5   	   /    )PRN212Assignment01_WPF__LINQ.CustomerInfo   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:PRN212Assignment01_WPF__LINQ     5   	     � Title$  CustomerInfo��5   	   $	��450��6   $	��800��6+   
����� �.��5
      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��4* �6   6,   .+�5   
   �� $��10q�6   .+�5      �� $��
My Profile��6   $��20(�6*   $
��Bold"�68   $��0,0,0,20q�6J   �� 5      $��
Full Name:��6   $
��Bold"�6)   �� 5      -   5         ��Name$ txtFullName��5      $��0,0,0,10q�6+   �� 5      $��
Telephone:��6   $
��Bold"�6)   �� 5      -   5        $ txtTelephone��5      $��0,0,0,10q�6,   �� 5      $��Email Address:��6   $
��Bold"�6-   �� 5      -   5        $ txtEmailAddress��5      $��0,0,0,10q�6/   �� 5      $��	Birthday:��6   $
��Bold"�6(   �� 5      -   5        $ txtBirthday��5      $��0,0,0,10q�6+   �� 5      $��	Password:��6   $
��Bold"�6(   �� 5       -   5        $ txtPassword��5       $��0,0,0,10q�6+   �� 5!      -   5        $��btnSave��5!   ?   $
��50px��6   $
��30px��6"   $
��Save��60   6]   5"      �� 5#   
   $��1��6   $��	0,0,0,102q�6%   .+�5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      �� -   5        $��btnBookRoom��5%   [   $��100px��6   $
��30px��6'   $��0,0,50,0q�65   $��	Book Room��6G   6n   �� 5&      -   5        $��btnViewBooking��5&   L   $��100px��6   $
��30px��6'   $��View Booking��65   6b   5'      &   System.Windows.Controls.DataGrid  5(      -	   5          Name$ dataGridBookings��5(         AutoGenerateColumns$ False��61      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6)      Header$ Booking Date��64   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6J   �� *BookingDate+  5+      $ 1* 6)   $ Total Price��64   	 6I   �� *
TotalPrice+  5,      $ 1* 6)   $ Booking Status��64   	 6L   �� *BookingStatus+5.      50      �� 51   
   -
   5        
 ��Name$
 	btnLogout��51      $��Logout��6%   $	��100��66   $��30��6B   $��83,367,84,37q�6i   52      53      