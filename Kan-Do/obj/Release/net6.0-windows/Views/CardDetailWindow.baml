   M S B A M L   `   `   `  ���� E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  =#clr-namespace:Kan_Do.WPF.ViewModelsKan_Do.WPF.ViewModels  '    !Kan_Do.WPF.Views.CardDetailWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Kan_Do.WPF.Views     2VM#clr-namespace:Kan_Do.WPF.ViewModels       � Title$  New Card��$	��480��$	��300��$	��480��$	��300��.��� .+��� $��
20 50 20 0q�.+��� $��New Card��$
��Lato)�$
��Bold"�$
��Left=�$	��Top=�$��25(��  � ColumnDefinitions �� $��2* ��� $��* � � RowDefinitions �� �� .+��� $��	TASK NAME��$
��Lato)�$��12(�$��0 10 0 0q��� -    ��Name$ textCardTitle��$��1��   NewCardTextBoxStyle#���    �� TextWrapping$
 Wrap=� �� AcceptsReturn$
 True������ *
cardName+ �� UpdateSourceTrigger$ 	LostFocus=��� $��PRIORITY��$��1��$
��Lato)�$��12(�$��0 10 0 0q�$��Right=��� -    ��Name$ PriorityComboBx��$��10 0 0 0q�$��1��$��1�� �� 
IsReadOnly$
 True��$
��Lato)�
�������$��65��$��Right=�	 �� SelectedItem	 �� *
priority+$ 	LostFocus=��  �� ��  �� �� .+��� $��DUE DATE��$
��Lato)�$��12(�$��0 10 0 0q��� $��ASSIGNEE��$��1��$
��Lato)�$��12(�$��0 10 0 0q�(  "System.Windows.Controls.DatePicker  -   
  Name$
 DueDatePicker��$��0��$��1��$��0 0 10 0q�$��Center=�$��8q�$
��Lato)�   SelectedDate �� *	dueDate+$ 	LostFocus=� � 	Resources  �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 10���� -   $ AssigneeTextBx��$��1��$��1��$
 Wrap=�#���   $
 True������ *
assignee+$ 	LostFocus=��� $��DESCRIPTION��$
��Lato)�$��12(�$��0 10 0 0q��� -   $ DescriptionTxtBox��$
 Wrap=�#���   $
 True��$	��100������ *taskDescription+$ 	LostFocus=��� -    ��Name$ SaveCardInfoBtn��  HomeButtons#���  $
��SAVE��$
��Lato)�$��0 20 0 0q�$��10q����#1A9988$��0q�$
��Bold"�
����������� *ReturnCardDetails+ ��%:   '��       �� " ��.���  �@��CornerRadius$ 10��