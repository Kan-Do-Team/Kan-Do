   M S B A M L   `   `   `  ����E  AKan-Do.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kan_Do.WPF.ViewsKan_Do.WPF.Views  5   	   =#clr-namespace:Kan_Do.WPF.ViewModelsKan_Do.WPF.ViewModels  5   	   '    !Kan_Do.WPF.Views.CardDetailWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Kan_Do.WPF.Views     5   	   2VM#clr-namespace:Kan_Do.WPF.ViewModels     5   	     � Title$  New Card��5	   	   $	��480��6   $	��300��6'   $	��480��63   $	��300��6C   .��5
      � .+�5   
   �� $��
20 50 20 0q�6   .+�5      �� $��New Card��6   $
��Lato)�6'   $
��Bold"�69   $
��Left=�6K   $	��Top=�6f   $��25(�5      � 5       � ColumnDefinitions 5      �� 5      $��2* �6'   64   �� 5      $��* �6'   63    � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��	TASK NAME��6   $
��Lato)�6,   $��12(�6>   $��0 10 0 0q�6L   �� 5      -   5         ��Name$ textCardTitle��5      $��1��61      NewCardTextBoxStyle#���   6>    �� TextWrapping$
 Wrap=�5       �� AcceptsReturn$
 True��6.   ��5   m   �� *
cardName+ �� UpdateSourceTrigger$ 	LostFocus=�5   .   �� 5      $��PRIORITY��6   $��1��6+   $
��Lato)�6;   $��12(�6M   $��0 10 0 0q�6[   $��Right=�6m   �� 5      -   5         ��Name$ PriorityComboBx��5      $��10 0 0 0q�64   $��1��6G   $��1��6W    �� 
IsReadOnly$
 True��5      $
��Lato)�6-   
�������$��65��6R   $��Right=�6`   	 �� SelectedItem	 5   d   �� *
priority+$ 	LostFocus=�5       5!      � 5$       5%      �� 5&      6)   �� 5'      6)    5)      �� 5*      6&   �� 5+      6&   .+�5.      �� $��DUE DATE��6   $
��Lato)�6+   $��12(�6=   $��0 10 0 0q�6K   �� 5/      $��ASSIGNEE��6   $��1��6+   $
��Lato)�6;   $��12(�6M   $��0 10 0 0q�6[   (  "System.Windows.Controls.DatePicker  51      -   5        
  Name$
 DueDatePicker��51      $��0��64   $��1��6D   $��0 0 10 0q�6Q   $��Center=�6d   $��8q�52   ]   $
��Lato)�6i      SelectedDate 6   �� *	dueDate+$ 	LostFocus=� � 	Resources 53       �� 
TargetType �� Property �� Value��%_   '��       �� 54      " ��6    .�55      ��  �@��CornerRadius$ 10��6=   56      57      58      �� 59      -   5        $ AssigneeTextBx��59      $��1��62   $��1��6B   $
 Wrap=�6�   #���   5:      $
 True��6H   ��59   O   �� *
assignee+$ 	LostFocus=�5:   H   5;      �� 5=      $��DESCRIPTION��6   $
��Lato)�6*   $��12(�6<   $��0 10 0 0q�6J   �� 5>      -   5        $ DescriptionTxtBox��5>      $
 Wrap=�62   #���   6F   $
 True��5?      $	��100��6+   ��5>   t   �� *taskDescription+$ 	LostFocus=�5?   +   �� 5A      -   5         ��Name$ SaveCardInfoBtn��5A        HomeButtons#���  6.   $
��SAVE��6T   $
��Lato)�5B      $��0 20 0 0q�6'   $��10q�69   ���#1A9988$��0q�6[   $
��Bold"�5C      
���������5A   d   �� *ReturnCardDetails+ 5D      ��%_   '��       �� 5E      " ��6   .�5F      ��  �@��CornerRadius$ 10��69   5G      5H      5I      5L      5j      5k      