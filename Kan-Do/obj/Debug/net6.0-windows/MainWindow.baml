   M S B A M L   `   `   `  ����E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Kan_Do.WPF.State.NavigatorsKan_Do.WPF.State.Navigators  5   	   'clr-namespace:Kan_Do.WPF
Kan_Do.WPF  5   	   =#clr-namespace:Kan_Do.WPF.ViewModelsKan_Do.WPF.ViewModels  5   	   =#clr-namespace:Kan_Do.WPF.ConvertersKan_Do.WPF.Converters  5	   	       Kan_Do.WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9nav)clr-namespace:Kan_Do.WPF.State.Navigators     5   	   *localclr-namespace:Kan_Do.WPF     5   	   2vm#clr-namespace:Kan_Do.WPF.ViewModels     5   	   :
converters#clr-namespace:Kan_Do.WPF.Converters     5	   	     � Title$  KAN-DO��5
   	   $
��auto��6   $
��1200��6&   $
��1920��63   $
��1080��6C    � 	Resources 5      :   4Kan_Do.WPF.Converters.EqualValueToParameterConverter "  EqualValueToParameterConverter��%   &	          5   
   64   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   $	��180��6,   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$
 Auto �62    �� Triggers 5      �� 5       �� Binding 6*   �� *Authenticator.IsLoggedIn+ �� Value	 False6W   .a�5   "   ��  � ��$ 0 �6:   5      5      5      �� 5      $��0 �6   �� 5      $��* �6   	 � RowDefinitions	 5!   
   �� 5"      $
��auto �6   $	��120��6*   �� 5#      $��5* �6   .+�5&   
   �� $��0��6   $��2��6$   ��5'      �� 5(      
 �� Color$
 #E9EDEE��6"   5.      � 50   
   .+�51      � .+�52      �� $��15, 60, 5, 10q�6   $	��200��64   .+�53      ��  �� Orientation$ 
Horizontal=�6!   .+�54      �� $
��Hey,��6    $��14(�6/   $
��Lato)�6=   ���#686A6A$��0q�6d   $
��Bold"�6o   �� 55       K� Capitals$ AllSmallCaps=�6j   $��14(�56       $
��Lato)�6.   ���#686A6A$��0 5 0 0q�6U   $
��Bold"�6f   ��55   $   �� *64Authenticator.CurrentAccount.AccountHolder.FirstName+56   f   57      �� 58      $��
Basic Plan��6   $��14(�61   $
��Lato)�6?   ���#686A6A$��Light"�6f   $��0 -7 0 0q�6y   59      5;      ��5=      �� 5>      " �6    5?      �� 5@       6&   �� *Authenticator.IsLoggedIn+	 False6S   .a�5A      ��  � y�$ 	Collapsed=�6;   5B      5D      5F      � 5H   
   $��1��6   	 5I      �� 5J      $��75 �6    �� 5K      $��* �6    �� 5L      $��70 �6    .+�5N      �� $ Vertical=�6   .+�5O      �� -   5          HomeButtons#���  5O      $
��16 9q�6@   $��0��6O   $��1��6_   $	��140��6l   $
��Left=�5P      $	��top=�65   $��	20 0 15 0q�6M   ���#F3F7F8���#686A6A$
��Lato)�5Q   D   $��14(�5R      $��0q�6(   $��SemiBold"�6<   $
��Left=�5S   +   $��+ New Board��6M    J� BitmapEffect 5T      F� 5U       F� Color$
 gray��61    F� 	Direction$	 320Q�6>    F� Softness$	 0.8Q�6N    F� ShadowDepth$ 1Q�6]    F� Opacity$	 0.2Q�6m    5W      ��%_   '��       �� 5X      " ��6    .�5Y      ��  �@��CornerRadius$ 10��6=   5Z      5[      5\      �� 5]      $ 
Horizontal=�6   .+�5^      �� $��BOARDS��6   $��11(�6-   $
��Lato)�6;   ���#686A6A$��	20 10 0 0q�6b   $��SemiBold"�6u   �� 5_      $��1��6   ���#686A6A	 �� X1$ 0��6@   	 �� X2$ 80��6G   	 �� Y1$ 0��6O   	 �� Y2$ 0��6V   $��5 22 0 0q�6]   5`      5b      �� 5d      $��1��6   $
��Auto=�6(   .��5e      �� .+�5f      �� ��6#   �� *	boardList+��5g      �� 5h      .R�5i   "   �� $ Vertical=�6-   .+�5j   &   �� -   5        #���  5j   -   $
��16 9q�6S   $��0��6b   $��1��6r   $	��140��6�   $
��Left=�5k   -   $	��top=�6H   $��20 8 0 5q�6`   ���#F3F7F8���#686A6A$
��Lato)�5l   W   $��14(�5m   -   $��0q�6;   $��SemiBold"�6O   $	��140��5n   U   $
��Left=�5o   -   
 � Tag 5n   -   �� .��5p   *   �� $
��Wrap=�6O    �� TextAlignment$ Center=�6c   ��64   �� *	BoardName+6c    5q   *   F� 5r   .   $
 gray��6E   $	 320Q�6R   $	 0.5Q�6b   $	 0.5Q�6q   $	 0.2Q�6�    5t   *   ��%_   '��       �� 5u   .   " ��64   .�5v   2   ��  �@��CornerRadius$ 10��6Q   5w   /   5x   +   5y   '   5z   #   5{      5}      5~      5      �� 5�      -   5        #���  5�      $��2��6;   $��20 15 10 20q�6H   $��Log Out��6]   *   $Kan_Do.WPF.State.Navigators.ViewType   Login#��Z 5�      $	��140��5�      $
��Left=�6!   $
��16 9q�6<   $��14(�5�      $��0q�6#   $��SemiBold"�67   ���#F3F7F8���#686A6A$
��Lato)�5�   @   ��5�   $   �� *UpdateCurrentViewModelCommand+ 5�      F� 5�      $
 gray��6-   $	 320Q�6:   $	 0.5Q�6J   $	 0.5Q�6Y   $	 0.2Q�6k    5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 10��69   5�      5�      5�      ��5�      �� 5�      " �6    5�      �� 5�       6&   �� *Authenticator.IsLoggedIn+	 False6S   .a�5�      ��  � y�$ 	Collapsed=�6;   5�      5�      5�      � 5�   
   $��2��6   ��5�      �� 5�      " �6    5�      �� 5�       6&   �� *Authenticator.IsLoggedIn+	 False6S   .a�5�      ��  � y�$ 	Collapsed=�6;   5�      5�      .+�5�      �� $��Right=�6   $��50��60   $��	0,40,50,0q�6<   $��0��6O   $	��Top=�6]   $	��250��6u   $��/kando_logo.png��6�   5�      �� 5�   
   $
��auto=�6   $
��Auto=�6<   $��1��6_   $��2��6l   $��2��6|   .��5�      �� ��6   �� *Navigator.CurrentViewModel+5�      5�      5�      