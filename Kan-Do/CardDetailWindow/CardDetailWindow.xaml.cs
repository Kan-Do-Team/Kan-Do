using GalaSoft.MvvmLight.Messaging;
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

namespace Kan_Do.KanbanBoard
{
    /// <summary>
    /// Interaction logic for CardDetailWindow.xaml
    /// </summary>
    public partial class CardDetailWindow : Window
    {
        public CardDetailWindowViewModel KCardVM;
        //public event EventHander<TextEventArgs> NewCardChanged;
        //private string newCard;
        public CardDetailWindow(int colId)
        {
            InitializeComponent();
            initView(colId);
           // SaveCardInfoBtn.Click += new EventHandler(SaveCardData);
           // Controls.Add(SaveCardInfoBtn);
        }


        private void initView(int columnId)
        {
            KCardVM = new CardDetailWindowViewModel() {ColumnID = columnId};
            DataContext= KCardVM;
            PriorityComboBx_Loaded();
            SetCreatedDate();
            Messenger.Default.Register<KanbanCard>(this, (Action) => RecieveInputMessage(Action));        
        }

        //Once the Card object has been received by the parent, then it will close this view
        private void RecieveInputMessage(KanbanCard cardDetails)
        {
            this.Close();
        }

        //Load the Priority combobox
        private void PriorityComboBx_Loaded()
        {
            List<int> prioritylevels = new List<int>();
            prioritylevels.Add(1);
            prioritylevels.Add(2);
            prioritylevels.Add(3);

            PriorityComboBx.ItemsSource=prioritylevels;

            //Empty first line in the combo
            PriorityComboBx.Text = String.Empty;
            PriorityComboBx.SelectedIndex = -1;
        }

        //Populate DateCreated textbox with today's date 
        private void SetCreatedDate()
        {
            //Generate the datetime for today, output to the UI and save in the viewmodel
            DateTime thisDay = DateTime.Today;
            DateCreatedTxtBx.Text = thisDay.ToString("D");
            KCardVM.KCard.DateCreated = thisDay;
        }
        

        //Event for the Save button, that will take in all of the UI information and add it to the viewmodel Card object
        /*private void SaveCardData(object sender, RoutedEventArgs e)
        {
            //Gather all of the data in the UI 
            if (textCardTitle.Text != null) { KCardVM.KCard.CardName = textCardTitle.Text; }
            if (DescriptionTxtBox.Text != null) { KCardVM.KCard.TaskDescription = DescriptionTxtBox.Text; }
            if (DueDatePicker.SelectedDate != null) { KCardVM.KCard.DueDate = (DateTime)DueDatePicker.SelectedDate; }
            if(PriorityComboBx.SelectedItem != null) { KCardVM.KCard.Priority = (int)PriorityComboBx.SelectedItem; }
            if (AssigneeTextBx.Text != null) { KCardVM.KCard.Assignee = AssigneeTextBx.Text; }
        }*/

       /* private void SaveCardData(object sender, EventArgs e)
        {
           // NewCardChanged = textCardTitle.Text;
           // EventHandler<TextEventArgs> eh = NewCardChanged;

             //if (eh != null)
                //eh(this, e);
        }*/
    }
}
