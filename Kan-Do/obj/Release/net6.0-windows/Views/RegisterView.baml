   M S B A M L   `   `   `  ���� E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components #    Kan_Do.WPF.Views.RegisterView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:Kan_Do.WPF.Views     X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM       � 	Resources      BooleanToVisibilityConverter��%   &	        �� .��� ����  �� ImageSource$ /Views/images/login.png�� j� Stretch$ UniformToFill=� j� 
AlignmentX$ Center=� j� 
AlignmentY$ Center=� �� 	Transform ��  �� ScaleX$ 1Q� �� ScaleY$ 1Q�.+��  � ColumnDefinitions �� $��* ��� $��* �	 � RowDefinitions	 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��2��.+��� $��Center=�$��60��$	��400��$"��/Views/images/logo_white.png��$��
0 ,60, 0,0q��� $!��Please register to continue��$��Center=�$��0q�$��14(�
�������$
��Lato)��� $��1��$��	10 0 10 0q�$��Right=�$��Center=�$	��115��.+��� $��
FIRST NAME��
�������$
��Lato)�$��12(�$��	0 10 0 0 q���   LoginTextBoxStyle#��[ ���� *	FirstName+
 �� UpdateSourceTrigger$
 PropertyChanged=��� $��1��$��1��$��	10 0 10 0q�$
��Left=�$	��115��.+��� $��	LAST NAME��
�������$
��Lato)�$��12(�$��	0 10 0 0 q��� #��[ ���� *
LastName+$
 PropertyChanged=��� $��2��$	��250��$��2��.+��� $��EMAIL��
�������$
��Lato)�$��12(�$��	0 10 0 0 q��� #��[ $��0 0 0 10q����� *Email+$
 PropertyChanged=��� $��PASSWORD��
�������$
��Lato)�$��12(�$��0 0 0 0 q�4  .PasswordBoxMVVM.Components.BindablePasswordBox  $��0 0 0 10q�   Password �� *
Password+�� $��CONFIRM PASSWORD��
�������$
��Lato)�$��12(�$��0 0 0 0q�   �� *ConfirmPassword+�� $��0 30 0 0q�$��REGISTER�� �� 	IsDefault$
 True��  LoginButtonStyle#���  ���� *RegisterCommand+   �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 10����   LoginNav#���  $��10 10 10 20q�$��Already have an account?������ *ViewLoginCommand+�� $��Center=�
������� � DataContext �� *ErrorMessageViewModel+���� *	Message+y��� *
HasMessage+ �� 	Converter# [  