   M S B A M L   `   `   `  ����T  PLKS Laundry NET Framework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LKS_LaundryLKS_Laundry  5          LKS_Laundry.Package   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:LKS_Laundry     5        N� Title$  Package��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��Center=�6   $��0��6-   .��6:   Manage Package6J   �� 5   
   $��Right=�6    �� Orientation$ 
Horizontal=�61   $��1��6J   .+�5      �� .��6   Search6   �� 5      $	��300��6   $��4q�6#   60   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridEmployee��5       $��2��6   6Q   � 5   
   $��3��6    5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      .+�5)      �� $��0��6   $��0��6!   .��61   
Package ID6=   �� 5*      -   5         ��Name$ 	ServiceID��5*      $��0��6)   $��1��66   $��4q�6F   6S   �� 5,      $��1��6   $��0��6!   .��61   	Service6:   �� 5-      -   5         ��Name$ ServiceName��5-      $��1��6,   $��1��69   $��4q�6I   6V   �� 5/      $��2��6   $��0��6!   .��61   
Total Unit6=   �� 50      -   5        $ Category��50   ;   $��2��6M   $��1��6Z   $��4q�6j   6w   �� 52      $��3��6   $��0��6!   .��61   Price68   �� 53      -   5        $
 Unit��53   ;   $��3��6I   $��1��6V   $��4q�6f   6s   �� 56      $ 
Horizontal=�6   $��1��62   $��2��6?   $��3��6O   $��Center=�6c   .+�57      �� -   5        $��Center=�57   .   $��Center=�6K   $
��15 5q�6f   $��5q�6u   .��6�   Insert6�   �� 58      -   5        $��Center=�58   .   $��Center=�6K   $
��15 5q�6f   $��5q�6u   .��6�   Update6�   �� 59      -   5        $��Center=�59   .   $��Center=�6K   $
��15 5q�6f   $��5q�6u   .��6�   Delete6�   5:      �� 5;      $ 
Horizontal=�6   $��2��62   $��2��6?   $��3��6O   $��Center=�6c   .+�5<      �� -	   5        $��Center=�5<   ,   $��Center=�6I   $
��15 5q�6d   $��5q�6s   .��6~   Save6�   �� 5=      -
   5        $��Center=�5=   .   $��Center=�6K   $
��15 5q�6f   $��5q�6u   .��6�   Cancel6�   5>      5?      5@      5A      