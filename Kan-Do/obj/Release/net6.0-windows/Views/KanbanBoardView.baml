   M S B A M L   `   `   `  ���� E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  =#clr-namespace:Kan_Do.WPF.ConvertersKan_Do.WPF.Converters  &     Kan_Do.WPF.Views.KanbanBoardView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:Kan_Do.WPF.Views     :
converters#clr-namespace:Kan_Do.WPF.Converters       � 	Resources  5   /Kan_Do.WPF.Converters.PriorityToColourConverter   PriorityToColourConverter5  /Kan_Do.WPF.Converters.PriorityToStringConverter  PriorityToStringConverter7   1Kan_Do.WPF.Converters.StringToVisibilityConverter  StringToVisibilityConverter��%-   &	        &	      &	 
           .��� $��Stretch=� � RowDefinitions �� $��75 ��� .+�� -    �Name$ ControlsPanel��$��0�� �� $��60 � � ColumnDefinitions �� $��2* ��� $��* �.+���  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ 
BoardTitle��$��45 0 0 0q�$
��auto��$
��auto��$
��Left=�$	��Top=�$��50(� �� 	MaxLength$ 21��$��0q�$
��Lato)�$
��Bold"����� *	BoardName+�� -    ��Name$ SaveBtn��  HomeButtons#���  $��40��$��0��$��1��$
��SAVE��$
��Left=�$��Center=�$��20 10q�$
��Lato)�$
��Bold"�
����������#C4C4C4$��0q�$��20 0 0 0q�   �� 
TargetType	 �� Property
 �� Value��%:   '��       �� " ��.��� 	 �@��CornerRadius$
 15�� J� BitmapEffect F�  F� Color$
 gray�� F� 	Direction$	 320Q� F� Softness$	 0.8Q� F� ShadowDepth$ 2Q� F� Opacity$	 0.2Q��� -   $ AddColumnButton��#���  $��1��$��40��$��
NEW COLUMN��$��Right=�$��Center=�$��20 10q�$
��Lato)�$
��Bold"�
����������#1A9988$��0q�$��20 0 0 0q�  ��%:   '��       �� " ��.��� 	 �@��CornerRadius$
 15�� F� $
 gray��$	 320Q�$	 0.8Q�$ 2Q�$	 0.2Q��� $ 
Horizontal=�$��1��$��Right=�� $��1��$
��Left=�$	��Top=�.+��� $ Vertical=�$��	20 0 0 35q�$��Stretch=�.+���  � DataContext �� ���� *boardColumns+���� .R��� $	��285�����#F2F4F6���#F2F4F6$��1q� �� CornerRadius$ 20�� �� Padding$ 0 0 0 15q�$��
15 15 15 0q�._��  �� $��70���� $��* �.+��� ���#F2F4F6���#F2F4F6$��0q�$ 	20 20 0 0��$ 5q�._��� $��0��$��50��$ 
Horizontal=�.+��� $ 
ColumnName��$��20��$	��100��$	��Top=�$��15q����#F2F4F6$��0q�$
��Lato)� �� CharacterCasing$ Upper=�$��12(����� *
ColumnName+�� $ ShiftLeftButton��-   #���  $��28��$��26��$��<��$��Right=�$��0 0 0 0q�$��21(�$��SemiBold"�$
��Lato)�$��0q�
����������#C4C4C4$��0q� � ToolTip$ Shift Column Left��
 � Tag ��   ��%A   '��       �� " ��.��� 	 �@��CornerRadius$
 	15 0 0 15���� $ ShiftRightButton��-   #���  $��28��$��26��$��>��$��Right=�$��0 0 0 0q�$��21(�$��SemiBold"�$
��Lato)�$��0 0 10 0q�
����������#C4C4C4$��1 0 0 0q�
�������$ Shift Column Right�� ��   ��%A   '��       �� " ��.��� 	 �@��CornerRadius$
 	0 15 15 0���� $ AddCard��-   #���  $��+��$��26��$��25��$��0 0 10 0q�$��Center=�$��0 0 0 0q�$ Add a New Card��$
��Bold"�$��21(����#C4C4C4
�������$��0q� ��   ��%:   '��       �� " ��.��� 	 �@��CornerRadius$
 20���� $ RemoveColumnButton��-   #���  $��0 0 20 0q�$��0 0 0 0q�$��25��$��26��$��19(�$��x��$��Right=�$��0q����#C4C4C4$��SemiBold"�
�������$ Delete Column�� ��   ��%:   '��       �� " ��.��� 	 �@��CornerRadius$
 20��� -	    J� 	AllowDrop$
 True��
������ $��1��$	��600��.+���  ��Name$ CardListPanel��-
   $
 True��
������ $��1��$
��Left=�$	��top=�.+��� $��CardList��$��1������ *column_cards+���� .R��� $ CardInfo��$ Vertical=� F� $
 gray��$	 320Q�$	 0.8Q�$ 2Q�$	 0.2Q�.+��� -   
�������$ 20��$��
20 5 20 10q�._�� $	��240�� �� $
��Auto �.+��� $��18q�.+�� .+��� $��0q�$ 12��$
��Left=�$ 6 1 6 1q�$��0 0 0 5q����� *
Priority+ �� 	Converter# [  ._���  ��Name$ CardPriority��$
��Lato)�$
��Bold"�
�������$
��Left=�$��10(����� *
Priority+# [ �� $��Right=�$	��Top=�$ 
Horizontal=�.+��� $ EditCardButton��-   #���  $��0 0 5 0q�$��0q�$
��Left=�$��0q�
�������
�������$ 	Edit Card�� ��   ��%:   '��       �� " ��.��� 	 �@��CornerRadius$
 20��.���� $ ��/Views/images/editicon.png��$��15���� $ RemoveCardButton��-   #���  $��5 0 0 0q�$��0 0 0 0q�$��20��$��24��$��19(�$��x��$��Right=�$��0q�
�������$��SemiBold"����#C4C4C4$ Delete Card�� ��   ��%:   '��       �� " ��.��� 	 �@��CornerRadius$
 20����  ��Name$ CardName��$
��Wrap=�$
��Lato)�$
��Bold"�$��18(�$��0 5 0 0q����� *
CardName+ �� Mode$ TwoWay=�y��� *
CardName+$ TwoWay=�# [ �� $ CardDueDate��$
��Wrap=�$
��Lato)�$��12(����#686A6A$��0 5 0 0q�$��SemiBold"����� *	DueDate+ �� StringFormat$ MMMM d yyyy���� $ CardAssignee��$
��Wrap=�$
��Lato)�$��12(����#686A6A$��0 5 0 0q����� *
Assignee+y��� *
Assignee+$ TwoWay=�# [ �� $ CardDesc��$
��Wrap=�$
��Lato)�$��12(����#686A6A$��0 5 0 0q����� *TaskDescription+y��� *TaskDescription+$ TwoWay=�# [ �� $ TestEventReturn��$��5��$��4��$��0������ .R�A�  A� Rows$ 1��