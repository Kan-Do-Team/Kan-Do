   M S B A M L   `   `   `  ����E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  5   	   I)clr-namespace:Kan_Do.WPF.State.NavigatorsKan_Do.WPF.State.Navigators  5   	   J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components 6?   $    Kan_Do.WPF.Views.LoginPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Kan_Do.WPF.Views     5   	   9nav)clr-namespace:Kan_Do.WPF.State.Navigators     5   	   X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     6?     � 	Resources  5          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      � ��5   
   �� 5       �� ImageSource$ /Views/images/login.png��6    j� Stretch$ UniformToFill=�6?    j� 
AlignmentX$ Center=�6W    j� 
AlignmentY$ Center=�6k    �� 	Transform 5      �� 5       �� ScaleX$ 1Q�6%    �� ScaleY$ 1Q�60   5       � ColumnDefinitions 5   
   �� 5      $��* �6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5    
   �� $��0��6   .+�5!      �� $��Center=�6   $��60��61   $	��400��6=   $"��/Views/images/logo_white.png��6I   $��0 ,120, 0,0q�6o   �� 5"      $��Please log-in to continue��6   $��Center=�68   $��0q�6U   $��14(�6`   
�������$
��Lato)�6�   5#      �� 5%   
   $��1��6   $��0 0 0 0q�6"   $	��250��63   .+�5&      �� $��EMAIL��6   
�������$
��Lato)�68   $��12(�6J   $��	0 10 0 0 q�6X   �� 5'        LoginTextBoxStyle#��[ 6   $��0 0 0 10q�5(      ��5)      �� *Email+
 �� UpdateSourceTrigger$
 PropertyChanged=�.��6N     5*       �� 
TargetType �� Property �� Value��%_   '��       �� 5+      " ��6   .�5,      ��  �@��CornerRadius$ 10��69   5-      5.      .��6%   5/      �� 50      $��PASSWORD��6   
�������$
��Lato)�6;   $��12(�6M   4  .PasswordBoxMVVM.Components.BindablePasswordBox  51      $��0 0 0 30q�52   -      Password 51   -   �� *
Password+52   -   �� 54      $��8q�55      $��0q�56      $��LOGIN��57       �� 	IsDefault$
 True��59        LoginButtonStyle#���  5:      ��58      �� *LoginCommand+  5;      ��%_   '��       �� 5<      " ��6   .�5=      ��  �@��CornerRadius$ 10��69   5>      5?      5@      �� 5B        LoginNav#���  6   $��10 10 10 20q�6:   $��Don't have an account?��6O   ��6p   �� *ViewRegisterCommand+5C      �� 5E      $��Center=�6   
������� � DataContext 5F      �� *ErrorMessageViewModel+��5G   +   �� *	Message+y�5H      �� *
HasMessage+ �� 	Converter# [  5I      5L      5M      