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
            ReturnCardDetails = new GalaSoft.MvvmLight.Command.RelayCommand(ProcessCardDetails);
            Messenger.Default.Register<KanbanCard>(this, (action) => RecieveCardInfo(action));
        }

        public int ColumnID
        {
            get { return KCard.ColumnId; }
            set { KCard.ColumnId = value; }
        }

        //Function to Add a card 
        public void SaveCardDetails()
        {
            //Compress the details to send to the KanbanBoardViewModel
            //var CardRelayModel = CompressCardInfo();
            //Messenger.Default.Send<SaveCardDetailsCommand>(CardRelayModel);
        }

        private void ProcessCardDetails()
        {
            var CRelayModel = KCard;
            Messenger.Default.Send<KanbanCard>(CRelayModel);
        }

        private object RecieveCardInfo(KanbanCard context)
        {
            //Add the reference of the columnId
            KCard.ColumnId = context.ColumnId;
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
