   M S B A M L   `   `   `  ����W  SPRN212Assignment01_WPF _LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PRN212Assignment01_WPF__LINQPRN212Assignment01_WPF__LINQ  5   	   +    %PRN212Assignment01_WPF__LINQ.Register   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:PRN212Assignment01_WPF__LINQ     5   	     � Title$  Register��5   	   $	��450��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $��2* �6   6,   �� 5      $��* �6   6+   .+�5   
   �� $��1��6   $��10q�6%   .+�5      �� $��Register��6   $��Center=�6(   $��20(�6E   $
��Bold"�6S   $��0,0,0,20q�6e   �� 5      $��
Full Name:��6   $
��Bold"�6)   �� 5      -   5         ��Name$ txtFullName��5      $��0,0,0,10q�6+   �� 5      $��
Telephone:��6   $
��Bold"�6)   �� 5      -   5        $ txtTelephone��5      $��0,0,0,10q�6,   �� 5      $��Email Address:��6   $
��Bold"�6-   �� 5      -   5        $ txtEmailAddress��5      $��0,0,0,10q�6/   �� 5      $��	Birthday:��6   $
��Bold"�6(   (  "System.Windows.Controls.DatePicker  5      -   5        $��dpkDate��5      $��0,0,0,10q�6(   6=   �� 5      $��	Password:��6   $
��Bold"�6(   �� 5       -   5        $ txtPassword��5       $��0,0,0,10q�6+   �� 5"      $��Confirm Password:��6   $
��Bold"�60   �� 5#      -   5        $ txtConfirmPassword��5#      $��0,0,0,10q�62   �� 5%      -   5        $��btnSave��5%   A   $
��50px��6   $
��30px��6"   $��Submit��60   6_   5&      5(      5)      