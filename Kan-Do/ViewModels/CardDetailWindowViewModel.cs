using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;

namespace Kan_Do.WPF.ViewModels
{
    public class CardDetailWindowViewModel : INotifyPropertyChanged
    {
        //Object will be used to 
        public KanbanCard KCard;

        public GalaSoft.MvvmLight.Command.RelayCommand ReturnCardDetails { get; set; }

        //Constructor
        public CardDetailWindowViewModel()
        {
            KCard = new KanbanCard();
            KCard.DueDate = DateTime.Now;
            ReturnCardDetails = new GalaSoft.MvvmLight.Command.RelayCommand(ProcessCardDetails);
            Messenger.Default.Register<CardDetailWindowViewModel>(this, (action) => RecieveCardInfo(action));
        }

        public string cardName
        {
            get { return KCard.CardName; }
            set
            {
                KCard.CardName = value;
                OnPropertyChanged(nameof(cardName));
                System.Diagnostics.Debug.WriteLine(KCard.CardName);

            }
        }

        public int cardID
        {
            get { return KCard.CardID; }
            set
            {
                KCard.CardID = value;
                OnPropertyChanged(nameof(cardID));
                System.Diagnostics.Debug.WriteLine(KCard.CardID);
            }
        }

        public DateTime dueDate
        {
            get { return KCard.DueDate; }
            set
            {
                KCard.DueDate = value;
                OnPropertyChanged(nameof(dueDate));
                System.Diagnostics.Debug.WriteLine(KCard.DueDate);
            }
        }

        public int priority
        {
            get { return KCard.Priority; }
            set
            {
                KCard.Priority = value;
                OnPropertyChanged(nameof(priority));
                System.Diagnostics.Debug.WriteLine(KCard.Priority);
            }
        }

        public string taskDescription
        {
            get { return KCard.TaskDescription; }
            set
            {
                KCard.TaskDescription = value;
                OnPropertyChanged(nameof(taskDescription));
                System.Diagnostics.Debug.WriteLine(KCard.TaskDescription);
            }
        }

        public string assignee
        {
            get { return KCard.Assignee; }
            set
            {
                KCard.Assignee = value;
                OnPropertyChanged(nameof(assignee));
                System.Diagnostics.Debug.WriteLine(KCard.Assignee);
            }
        }

        public int ColumnID
        {
            get { return KCard.ColumnId; }
            set
            {
                KCard.ColumnId = value;
                OnPropertyChanged(nameof(ColumnID));
                System.Diagnostics.Debug.WriteLine(KCard.ColumnId);
            }
        }

        /*
        //Function to Add a card 
        public void SaveCardDetails(String cardName, int cardID, DateTime dueDate, int priority, String taskDescription, String assignee, int columnid)
        {
            System.Diagnostics.Debug.WriteLine(cardName);
            System.Diagnostics.Debug.WriteLine(cardID);
            System.Diagnostics.Debug.WriteLine(dueDate);
            System.Diagnostics.Debug.WriteLine(priority);
            System.Diagnostics.Debug.WriteLine(taskDescription);
            System.Diagnostics.Debug.WriteLine(assignee);
            System.Diagnostics.Debug.WriteLine(columnid);
        }
      */

        private void ProcessCardDetails()
        {
            var CRelayModel = this;
            Messenger.Default.Send<CardDetailWindowViewModel>(CRelayModel);
        }

        private object RecieveCardInfo(CardDetailWindowViewModel context)
        {
            //Add the reference of the columnId
            KCard.ColumnId = context.ColumnID;
            return null;
        }

        //Added property change notification to cards
        #region INotifyPropertyChanged Cards

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}