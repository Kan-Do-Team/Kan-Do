using Kan_Do.Domain.Models;
using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kan_Do.WPF.Views
{
    /// <summary>
    /// Interaction logic for KanbanBoardView.xaml
    /// </summary>
    public partial class KanbanBoardView : UserControl
    {
        public KanbanBoardViewModel KBoardVM;
        
        public static readonly DependencyProperty CardDropCommandProperty = DependencyProperty.Register("CardDropCommand", typeof(ICommand), typeof(KanbanBoardView), new PropertyMetadata(null));

        public KanbanCard card { get; set; }
        public int originalColumnID { get; set; }

        public ICommand CardDropCommand
        {
            get { return (ICommand)GetValue(CardDropCommandProperty); }
            set { SetValue(CardDropCommandProperty, value); }
        }
        
        public KanbanBoardView()
        {
            InitializeComponent();
            //KBoardVM = ((KanbanBoardViewModel)(this.));
            //KanbanBoardViewM
            //DataContext = KBoardVM;
            //ColumnsList.ItemsSource = KBoardVM.boardColumns;
            //ColumnsList.DataContext = KBoardVM;
        }

        private void AddColumn(object sender, RoutedEventArgs e)
        {
            //Call the function in the ViewModel that adds a column
            ((KanbanBoardViewModel)DataContext).addColumn();
        }

        private void DeleteColumn(object sender, RoutedEventArgs e)
        {
            //Get the index of the element of the list that the Remove button was selected in
            KanbanColumn kcol = ((Button)sender).Tag as KanbanColumn;

            //Call the function in the VM, that will remove the element at the index 
            ((KanbanBoardViewModel)DataContext).deleteColumn(kcol.ColumnNumber);
        }

        /*private void OpenCardWindow_Click(object sender, RoutedEventArgs e)
        {
            Kan_Do.KanbanBoard cardWindow = new Kan_Do.KanbanBoard.CardDetailWindow();
            //Subscribe to event that sends card data back to the board
           // cardWindow.NewCardChanged += new EventHandler<TextEventArgs>(cardwindow_NewCardChanged);
            cardWindow.Show();
            //Unsubscribe to the event
           // cardWindow.NewCardChanged -= cardWindow_NewCardChanged;
        }*/

        //The new card event
        /*private void cardWindow_NewCardChanged(object sender, TextEventArgs e)
        {
           // TestEventReturn.Content = e.Text;
            //Use __ = e. ___ to load received data into the UI 
        }*/

        private void ShiftColumnLeft(object sender, RoutedEventArgs e)
        {
            //Get the index of the element of the list that the Shift button was selected in
            KanbanColumn k1col = ((Button)sender).Tag as KanbanColumn;

            //Call the function in the VM, that will edit the index of the column
            ((KanbanBoardViewModel)DataContext).shiftColumnLeft(k1col.ColumnNumber);
        }

        private void ShiftColumnRight(object sender, RoutedEventArgs e)
        {
            //Get the index of the element of the list that the Shift button was selected in
            KanbanColumn k1col = ((Button)sender).Tag as KanbanColumn;

            //Call the function in the VM, that will edit the index of the column
            ((KanbanBoardViewModel)DataContext).shiftColumnRight(k1col.ColumnNumber);
        }

        //Opens new card dialogue window
        private void NewCard(object sender, RoutedEventArgs e)
        {
            KanbanColumn k1col = ((Button)sender).Tag as KanbanColumn;
            //Sends ColumnID to CardDetailWindow
            ((KanbanBoardViewModel)DataContext).cardDetails(k1col.ColumnNumber);
        }
        
         private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(e.LeftButton == MouseButtonState.Pressed && sender is FrameworkElement frameworkElement)
            {
                card = (KanbanCard)frameworkElement.DataContext;
                originalColumnID = card.ColumnId;
                DragDrop.DoDragDrop(frameworkElement, new DataObject(DataFormats.Serializable, frameworkElement.DataContext), DragDropEffects.Move);
            }
        }

        private void CardDrop(object sender, DragEventArgs e)
        {
            if (sender is FrameworkElement frameworkElement && card.ColumnId != ((KanbanColumn)(frameworkElement.DataContext)).ColumnId)
            {
                ((KanbanBoardViewModel)DataContext).boardColumns[originalColumnID - 1].column_cards
                                    .Remove(((KanbanBoardViewModel)DataContext).boardColumns[originalColumnID - 1].column_cards.
                                    Where(i => (
                                    i.CardID == card.CardID &&
                                    i.CardName == card.CardName &&
                                    i.Priority == card.Priority &&
                                    i.TaskDescription == card.TaskDescription &&
                                    i.Assignee == card.Assignee &&
                                    i.DateCreated == card.DateCreated)).First());
                card.ColumnId = ((KanbanColumn)(frameworkElement.DataContext)).ColumnId;
                ((KanbanColumn)frameworkElement.DataContext).column_cards.Add(card);            
            }
        }

        private void RemoveCard(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement frameworkElement) {
                KanbanCard tmpCard = (KanbanCard)frameworkElement.DataContext;
                ((KanbanBoardViewModel)DataContext).boardColumns[tmpCard.ColumnId-1].column_cards
                                    .Remove(((KanbanBoardViewModel)DataContext).boardColumns[tmpCard.ColumnId - 1].column_cards.
                                    Where(i => (
                                    i.CardID == tmpCard.CardID &&
                                    i.CardName == tmpCard.CardName &&
                                    i.Priority == tmpCard.Priority &&
                                    i.TaskDescription == tmpCard.TaskDescription &&
                                    i.Assignee == tmpCard.Assignee &&
                                    i.DateCreated == tmpCard.DateCreated)).First());
            }
        }

        private void EditCard(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement frameworkElement)
            {
                KanbanCard tmpCard = (KanbanCard)frameworkElement.DataContext;

                //Sends ColumnID to CardDetailWindow
                KanbanCard edittedCard = ((KanbanBoardViewModel)DataContext).cardDetails(tmpCard);
                int columnIndex = edittedCard.ColumnId - 1;
                int cardIndex = ((KanbanBoardViewModel)DataContext).boardColumns[columnIndex].column_cards.IndexOf(((KanbanBoardViewModel)DataContext).boardColumns[columnIndex].column_cards.Where(i => i.CardID == edittedCard.CardID).First());
                ((KanbanBoardViewModel)DataContext).boardColumns[columnIndex].column_cards
                                   .Remove(((KanbanBoardViewModel)DataContext).boardColumns[columnIndex].column_cards.
                                   Where(i => i.CardID == tmpCard.CardID).First());
                ((KanbanBoardViewModel)DataContext).boardColumns[columnIndex].column_cards.Insert(cardIndex, edittedCard);
            }
        }
    }
}
