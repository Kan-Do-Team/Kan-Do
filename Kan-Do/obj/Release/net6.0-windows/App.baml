   M S B A M L   `   `   `  ���� E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Kan_Do.WPF.ViewModelsKan_Do.WPF.ViewModels  3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  'clr-namespace:Kan_Do.WPF
Kan_Do.WPF      Kan_Do.WPF.App   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     :
viewmodels#clr-namespace:Kan_Do.WPF.ViewModels     0viewsclr-namespace:Kan_Do.WPF.Views     *localclr-namespace:Kan_Do.WPF       �� 	Resources   �� MergedDictionaries �� Source �� DataType)   #Kan_Do.WPF.ViewModels.HomeViewModel   Kan_Do.WPF.Views.HomeView0   *Kan_Do.WPF.ViewModels.KanbanBoardViewModel&    Kan_Do.WPF.Views.KanbanBoardView.   (Kan_Do.WPF.ViewModels.LoginPageViewModel$   Kan_Do.WPF.Views.LoginPageView-   'Kan_Do.WPF.ViewModels.RegisterViewModel#   Kan_Do.WPF.Views.RegisterView �� 
TargetType �� Property �� Value-	  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name	 �� CornerRadius
 �� Padding �� Color'
  !System.Windows.VisualStateManager 
  VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState ��Name   LoginTextBoxStyle  NewCardTextBoxStyle  LoginButtonStyle J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName N� EnterActions g� Duration	 W� To �� TargetProperty N� ExitActions  LoginNav  HomeButtons  ScrollBarTrackThumb �Name � RowDefinitions ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton  ��Name! J� Opacity" ]� DecreaseRepeatButton# P� 
SourceName  ButtonSelectBrush  	DarkBrush$ �� Angle��  �� $ /Styles/Common.xaml?�%�  (��       *, +)(��      *, +)(�� $     *, +)(�� 6     *, +)'G� H     &	  n    &	 N    &	 r    &	 	    &	 /    &	 r    '�� �    �� "  .R�  �� "  .R�  �� "  .R�  �� "  .R�  �� " G�.���  �@J�SnapsToDevicePixels$
 true����  � ��
 �������  �@�OverridesDefaultStyle$
 true����  �@	 TabNavigation$
 None=���  � ��$
 Lato)���  � ��$ 12(���  �@J�	AllowDrop$
 true����  �@G�
CaretBrush
 �������  �@G�PasswordChar$	 ●����  � �� �� " G�.R��� $ Border��$	 10��$
 8q�$��1q����� $ Transparent������ $ White��   CommonStates��.   
Normal��  Disabled��  	MouseOver��._��� $ PART_ContentHost���� " ��.���  �@J�SnapsToDevicePixels$
 true����  � ��
 �������  �@�OverridesDefaultStyle$
 true����  �@	 TabNavigation$
 None=���  � ��$
 Lato)���  � ��$ 12(���  �@��
CaretBrush
 �������  � �� �� " ��.R��� $ Border��$	 10��$
 8q�$��1q����� $ Transparent������ $ White��   CommonStates��.   
Normal��  Disabled��  	MouseOver��._��� $ PART_ContentHost���� " ��.���  � ��$
 Lato)���  � ��$ 12(���  � �� �� " ��.R��� $ Border��$	 10��$
 8q�$��1q����� $ Transparent������ $
 Gray��   CommonStates��.   
Normal��  Disabled��  	MouseOver��._��� $ PART_ContentHost���� " ��.���  � ��
 ���� ��  � ��
 �������  � ��
 �������  � ��$ 2q���  � ��$ Center=���  � ��$ Center=���  � ��$ 8q���  � ��$
 Lato)���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border�� � ��
 ������� $ border�� � ��$ 2q���  �@J�Opacity$	 0.5Q�P�  �@J�IsMouseOver$
 true�� �� .���� .��W� $ 	0:0:0.200D� 0.8$ Opacity� �� .���� .��W� $ 	0:0:0.200D� 0.5$ Opacity�P�  � ��$
 true��. ��� $ border�� � ��
 ���� �� $ border�� � ��
 �������  �@J�Opacity$ 1Q�P�  � {�$ false��. ��� $ border�� � ��
 ���� �� $ border�� � ��
 �������  �@J�Opacity$ 1Q��� " ��.���  � ��
 ���� ��  � ��
 �������  � ��$ 0q���  �@J�Opacity$	 0.5Q���  � ��$ Center=���  � ��$ Center=���  � ��$ 0q���  � ��$
 Lato)���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border�� � ��
 ������� $ border�� � ��$ 2q���  �@J�Opacity$	 0.5Q�P�  �@J�IsMouseOver$
 true�� �� .���� .��W� $ 	0:0:0.200D� 1$ Opacity� �� .���� .��W� $ 	0:0:0.200D� 0.5$ Opacity�P�  � ��$
 true��. ���  �@J�Opacity$ 1Q�P�  � {�$ false��. ���  �@J�Opacity$	 0.5Q��� " ��.���  �@J�Opacity$	 0.8Q���  � ��$
 Lato)���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ���  �@J�Opacity$	 0.8Q�P�  �@J�IsMouseOver$
 true�� �� .���� .��W� $ 	0:0:0.200D� 1$ Opacity� �� .���� .��W� $ 	0:0:0.200D� 0.8$ Opacity�P�  � ��$
 true��. ���  �@J�Opacity$ 1Q�P�  � {�$ false��. ���  �@J�Opacity$	 0.8Q��� " n�.���  � �� �� " n�.R�� $
 Grid��.+��� $��Stretch=�$��Stretch=�$
��Auto��$
��Auto��
������ �� $ CornerScrollBarRectangle��$	 5��$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��$��0,1,0,1q�#��z�� P�  �@�Tag$ 
Horizontal��. ��� $ CornerScrollBarRectangle�� � ��$
 Auto���� $ CornerScrollBarRectangle�� � ��$ 6���� " ��.���  �@��IsFlicksEnabled$ false����  � �� �#ADABAB��  � ��
 ���� ��  � ��$ 7����  � �� �� " ��.R�� $ GridRoot��$��7��#��z�� �� $��0.00001* �.+�]� $ 
PART_Track��$��0��$
��true��$|�false�� n� $ Thumb��#��z��#���   �� $  PageUp��$��ScrollBar.PageDownCommand��$! 0Q�$|�false��" �� $  PageDown��$��ScrollBar.PageUpCommand��$! 0Q�$|�false�� P� $# Thumb�� �@J�IsMouseOver$
 true��. ��� # �  $ Thumb�� � ��P� $# Thumb�� �@n�
IsDragging$
 true��. ��� # �  $ Thumb�� � ��P�  � {�$ false��. ��� $ Thumb�� � y�$ 	Collapsed=�P�  �@��Orientation$ 
Horizontal=�. ��� $ GridRoot�� �@�LayoutTransform �� $	$ -90Q��� $ 
PART_Track�� �@�LayoutTransform �� $	$ -90Q���  � ��$
 Auto����  � ��$ 8���� $ Thumb�� �@�Tag$ 
Horizontal���� $ PageDown�� � ��$ ScrollBar.PageLeftCommand���� $ PageUp�� � ��$  ScrollBar.PageRightCommand��