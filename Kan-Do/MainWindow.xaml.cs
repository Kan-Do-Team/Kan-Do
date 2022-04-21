using Kan_Do.WPF.ViewModels;
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
using System.Windows.Shapes;

namespace Kan_Do.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(object dataContext)
        {
            InitializeComponent();

            DataContext = dataContext;
        }

        public void Logout(object sender, RoutedEventArgs e)
        {
            ((MainViewModel) DataContext).Logout();
        }

        public void AddBoard(object sender, RoutedEventArgs e)
        {
            KanbanBoardViewModel board = new KanbanBoardViewModel(((MainViewModel)DataContext).Authenticator, ((MainViewModel)DataContext).SaveState);
            board.FillInitialColumns();
            ((MainViewModel)DataContext).AddBoard(board);

        }


        public void UpdateViewModel(object sender, RoutedEventArgs e)
        {
            KanbanBoardViewModel board = ((Button)sender).Tag as KanbanBoardViewModel;
            ((MainViewModel)DataContext).UpdateCurrentViewModelCommand.Execute(board);
        }

    }
}
