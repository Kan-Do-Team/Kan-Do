   M S B A M L   `   `   `  ����E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  5      J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components 6;   #    Kan_Do.WPF.Views.RegisterView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Kan_Do.WPF.Views     5      X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     6;     � 	Resources  5          BooleanToVisibilityConverter��%   &	        �� 5	   
   6'   5
      .��5      � ��5   
   �� 5       �� ImageSource$ /Views/images/login.png��6    j� Stretch$ UniformToFill=�6?    j� 
AlignmentX$ Center=�6W    j� 
AlignmentY$ Center=�6k    �� 	Transform 5      �� 5       �� ScaleX$ 1Q�6%    �� ScaleY$ 1Q�60   5      .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   	 � RowDefinitions	 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5!      �� $��0��6   $��2��6&   .+�5"      �� $��Center=�6   $��60��65   $	��400��6A   $"��/Views/images/logo_white.png��6M   $��
0 ,60, 0,0q�6s   �� 5#      $!��Please register to continue��6   $��Center=�6>   $��0q�6[   $��14(�6f   
�������$
��Lato)�6�   5$      �� 5&      $��1��6   $��	10 0 10 0q�6&   $��Right=�69   $��Center=�6U   $	��115��6p   .+�5'      �� $��
FIRST NAME��6   
�������$
��Lato)�6A   $��12(�6S   $��	0 10 0 0 q�6a   �� 5(        LoginTextBoxStyle#��[ 6   ��6E   �� *	FirstName+
 �� UpdateSourceTrigger$
 PropertyChanged=�5)      �� 5+      $��1��6   $��1��6&   $��	10 0 10 0q�66   $
��Left=�6I   $	��115��6d   .+�5,      �� $��	LAST NAME��6   
�������$
��Lato)�6@   $��12(�6R   $��	0 10 0 0 q�6`   �� 5-      #��[ 6   ��6E   �� *
LastName+$
 PropertyChanged=�5.      �� 50      $��2��6   $	��250��6&   $��2��62   .+�51      �� $��EMAIL��6   
�������$
��Lato)�6<   $��12(�6N   $��	0 10 0 0 q�6\   �� 52      #��[ 6   $��0 0 0 10q�6E   ��6W   �� *Email+$
 PropertyChanged=��� 53      $��PASSWORD��6   
�������$
��Lato)�6?   $��12(�6Q   $��0 0 0 0 q�6_   4  .PasswordBoxMVVM.Components.BindablePasswordBox  54      $��0 0 0 10q�61      Password 6C   �� *
Password+�� 55      $��CONFIRM PASSWORD��6   
�������$
��Lato)�6G   $��12(�6Y   $��0 0 0 0q�6g     56       61   �� *ConfirmPassword+�� 58      $��0 30 0 0q�6   $��REGISTER��6-    �� 	IsDefault$
 True��6@     LoginButtonStyle#���  6u   ��6Q   �� *RegisterCommand+  59       �� 
TargetType �� Property �� Value��%_   '��       �� 5:      " ��6    .�5;      ��  �@��CornerRadius$ 10��6=   5<      5=      5>      �� 5@        LoginNav#���  6   $��10 10 10 20q�6=   $��Already have an account?��6R   ��6v   �� *ViewLoginCommand+5A      �� 5C      $��Center=�6   
������� � DataContext 69   �� *ErrorMessageViewModel+��6z   �� *	Message+y�6�   �� *
HasMessage+ �� 	Converter# [  5E      5H      5I      5J      