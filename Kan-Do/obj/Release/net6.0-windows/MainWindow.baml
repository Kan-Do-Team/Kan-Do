   M S B A M L   `   `   `  ���� E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Kan_Do.WPF.State.NavigatorsKan_Do.WPF.State.Navigators  'clr-namespace:Kan_Do.WPF
Kan_Do.WPF  =#clr-namespace:Kan_Do.WPF.ViewModelsKan_Do.WPF.ViewModels  =#clr-namespace:Kan_Do.WPF.ConvertersKan_Do.WPF.Converters      Kan_Do.WPF.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9nav)clr-namespace:Kan_Do.WPF.State.Navigators     *localclr-namespace:Kan_Do.WPF     2vm#clr-namespace:Kan_Do.WPF.ViewModels     :
converters#clr-namespace:Kan_Do.WPF.Converters       � Title$  KAN-DO��$
��auto��$
��1200��$
��1920��$
��1080�� � 	Resources :   4Kan_Do.WPF.Converters.EqualValueToParameterConverter "  EqualValueToParameterConverter��%   &	          .���  � ColumnDefinitions �� $
��auto �$	��180������  �� 
TargetType" ��.���  �� Property � �� �� Value$
 Auto � �� Triggers ��  �� Binding �� *Authenticator.IsLoggedIn+ �� Value	 False.a���  � ��$ 0 ��� $��0 ��� $��* �	 � RowDefinitions	 �� $
��auto �$	��120���� $��5* �.+��� $��0��$��2������ 
 �� Color$
 #E9EDEE��� .+�� .+��� $��15, 60, 5, 10q�$	��200��.+���  �� Orientation$ 
Horizontal=�.+��� $
��Hey,��$��14(�$
��Lato)����#686A6A$��0q�$
��Bold"���  K� Capitals$ AllSmallCaps=�$��14(�$
��Lato)����#686A6A$��0 5 0 0q�$
��Bold"����� *64Authenticator.CurrentAccount.AccountHolder.FirstName+�� $��
Basic Plan��$��14(�$
��Lato)����#686A6A$��Light"�$��0 -7 0 0q����� " � ��  �� *Authenticator.IsLoggedIn+	 False.a���  � y�$ 	Collapsed=�� $��1��	 �� $��75 ��� $��* ��� $��70 �.+��� $ Vertical=�.+��� -     HomeButtons#���  $
��16 9q�$��0��$��1��$	��140��$
��Left=�$	��top=�$��	20 0 15 0q����#F3F7F8���#686A6A$
��Lato)�$��14(�$��0q�$��SemiBold"�$
��Left=�$��+ New Board�� J� BitmapEffect F�  F� Color$
 gray�� F� 	Direction$	 320Q� F� Softness$	 0.8Q� F� ShadowDepth$ 1Q� F� Opacity$	 0.2Q� ��%:   '��       �� " ��.���  �@��CornerRadius$ 10���� $ 
Horizontal=�.+��� $��BOARDS��$��11(�$
��Lato)����#686A6A$��	20 10 0 0q�$��SemiBold"��� $��1�����#686A6A	 �� X1$ 0��	 �� X2$ 80��	 �� Y1$ 0��	 �� Y2$ 0��$��5 22 0 0q��� $��1��$
��Auto=�.���� .+��� ���� *	boardList+���� .R��� $ Vertical=�.+��� -   #���  $
��16 9q�$��0��$��1��$	��140��$
��Left=�$	��top=�$��20 8 0 5q����#F3F7F8���#686A6A$
��Lato)�$��14(�$��0q�$��SemiBold"�$	��140��$
��Left=�
 � Tag �� .���� $
��Wrap=� �� TextAlignment$ Center=����� *	BoardName+ F� $
 gray��$	 320Q�$	 0.5Q�$	 0.5Q�$	 0.2Q� ��%:   '��       �� " ��.���  �@��CornerRadius$ 10���� -   #���  $��2��$��20 15 10 20q�$��Log Out��*   $Kan_Do.WPF.State.Navigators.ViewType   Login#��Z $	��140��$
��Left=�$
��16 9q�$��14(�$��0q�$��SemiBold"����#F3F7F8���#686A6A$
��Lato)����� *UpdateCurrentViewModelCommand+ F� $
 gray��$	 320Q�$	 0.5Q�$	 0.5Q�$	 0.2Q� ��%:   '��       �� " ��.���  �@��CornerRadius$ 10������ " � ��  �� *Authenticator.IsLoggedIn+	 False.a���  � y�$ 	Collapsed=�� $��2������ " � ��  �� *Authenticator.IsLoggedIn+	 False.a���  � y�$ 	Collapsed=�.+��� $��Right=�$��50��$��	0,40,50,0q�$��0��$	��Top=�$	��250��$��/kando_logo.png���� $
��auto=�$
��Auto=�$��1��$��2��$��2��.���� ���� *Navigator.CurrentViewModel+