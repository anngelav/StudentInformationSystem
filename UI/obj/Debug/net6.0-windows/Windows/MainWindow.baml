   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	   -clr-namespace:UI.ComponentsUI.Components  5   	       UI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	   .local2clr-namespace:UI.Components     5   	     � Title$  List of all students��5	   	   $	��450��6&   $	��800��63    � WindowStartupLocation$ CenterScreen=�6?    � 	Resources 5
         UI.MainWindow   	something��%   &	          5   
   6   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��20 �6   .+�5   
   �� $��List of all users��6   $��1��6,   $��1��6<   $��30(�6I   $��Oblique$�6W   $
��Bold"�6k   
����+��6}   �� 5   
   -   5         ��Name$ unlock��5      $��2��6!   $��0��61   $
{�True��6Y   .��5      �� $U��OD:\TU-SOFIA\3 KURS\6 SEMESTAR\PS\StudentInformationSystem\UI\Windows\unlock.png��6   6o   5          UI.Components.StudentsList  5    
   -   5          Name$ studentsList��5           UI.Components.StudentsList   MouseDoubleClick$# StudentsList_MouseDoubleClick��6]   $��2q�64   $��3��6@   $��1��6M   6]   �� 5!   
   -   5        $
 edit��5!      $
��EDIT��6   $��1��6.   $��5��6>   $��30(�6K   ��6Y   �� *Edit_ClickCommand+��5"      �� 5#       �� 
TargetType" ��6   .�5$      �� 	 �� Property	 � ��
 �� Value

 �����63   �� 5%      	 � ��$
 0q�68   �� 5&      	 � ��

 �� ��63    �� Triggers 5'      P� 5(       P� Property � {� P� Value$ False��67   . �5)      �� 	 � ��

 ���� 6;   �� 5*      	 � ��$
 0q�6@   �� 5+      	 � ��

 �� ��6;   5,      5.      50      51      52      