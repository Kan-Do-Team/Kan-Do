   M S B A M L   `   `   `  ���� E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  I)clr-namespace:Kan_Do.WPF.State.NavigatorsKan_Do.WPF.State.Navigators  J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components $    Kan_Do.WPF.Views.LoginPageView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Kan_Do.WPF.Views     9nav)clr-namespace:Kan_Do.WPF.State.Navigators     X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM       � 	Resources      BooleanToVisibilityConverter��%   &	        �� .��� ����  �� ImageSource$ /Views/images/login.png�� j� Stretch$ UniformToFill=� j� 
AlignmentX$ Center=� j� 
AlignmentY$ Center=� �� 	Transform ��  �� ScaleX$ 1Q� �� ScaleY$ 1Q� � ColumnDefinitions �� $��* �	 � RowDefinitions	 �� $
��auto ��� $
��auto �.+��� $��0��.+��� $��Center=�$��60��$	��400��$"��/Views/images/logo_white.png��$��0 ,120, 0,0q��� $��Please log-in to continue��$��Center=�$��0q�$��14(�
�������$
��Lato)��� $��1��$��0 0 0 0q�$	��250��.+��� $��EMAIL��
�������$
��Lato)�$��12(�$��	0 10 0 0 q���   LoginTextBoxStyle#��[ $��0 0 0 10q����� *Email+
 �� UpdateSourceTrigger$
 PropertyChanged=�.��   �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 10��.���� $��PASSWORD��
�������$
��Lato)�$��12(�4  .PasswordBoxMVVM.Components.BindablePasswordBox  $��0 0 0 30q�   Password �� *
Password+�� $��8q�$��0q�$��LOGIN�� �� 	IsDefault$
 True��  LoginButtonStyle#���  ���� *LoginCommand+  ��%:   '��       �� " ��.���  �@��CornerRadius$ 10����   LoginNav#���  $��10 10 10 20q�$��Don't have an account?������ *ViewRegisterCommand+�� $��Center=�
������� � DataContext �� *ErrorMessageViewModel+���� *	Message+y��� *
HasMessage+ �� 	Converter# [  