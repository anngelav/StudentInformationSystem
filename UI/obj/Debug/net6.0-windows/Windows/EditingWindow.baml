   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:UI.Windows
UI.Windows  5   	       UI.Windows.EditingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:UI.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ EditingWindow��5	   	   $	��400��6   $	��340��6,   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��200 �6   �� 5      $	��100 �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��80 �6   �� 5      $��20 �6   .+�5   
   �� $)��#Changing the role of selected user:��6   $��1��6>   $��1��6K   $��Center=�6[   �� 5   
   $��	Username:��6   $��3��6$   $��1��61   $��Center=�6A   �� 5    
   $��3��6   $��2��6   $��Center=�6G   ��6-   �� *Names+6G   �� 5!   
   $��Current role:��6   $��5��6(   $��1��65   $��Center=�6E   �� 5"   
   $��5��6)   $��2��66   $��Center=�6F   ��6   �� *Role+6F   �� 5#   
   $��Changed role:��6   $��7��6(   $��1��65   $��Center=�6E   �� 5$   
   -   5         ��Name$
 role��5$      $��7��6    $��2��6-   �� 5%   
   -   5         ��Name$ submit��5%      $��9��6!   $��2��6.   $��40��6>   $��SUBMIT��6J   $��Center=�6[   6v   5&      5'      