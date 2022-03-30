using System;
using System.Collections.Generic;
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

namespace Kan_Do.KanbanBoard
{
    /// <summary>
    /// Interaction logic for KanbanBoardView.xaml
    /// </summary>
    public partial class KanbanBoardView : Page
    {
        public KanbanBoardViewModel KBoardVM;
        public KanbanBoardView()
        {
            InitializeComponent();
            KBoardVM = new KanbanBoardViewModel();
            DataContext = KBoardVM;
            ColumnsList.ItemsSource = KBoardVM.boardColumns;
            ColumnsList.DataContext = KBoardVM;
        }

        private void AddColumn(object sender, RoutedEventArgs e)
        {
            //Call the function in the ViewModel that adds a column
            KBoardVM.addColumn();
        }

        private void DeleteColumn(object sender, RoutedEventArgs e)
        {
            //Get the index of the element of the list that the Remove button was selected in
            KanbanColumn kcol = ((Button)sender).Tag as KanbanColumn;

            //Call the function in the VM, that will remove the element at the index 
            KBoardVM.deleteColumn(kcol.ColumnNumber);
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
    }
}
