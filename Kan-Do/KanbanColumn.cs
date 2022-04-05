using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF
{
    public class KanbanColumn : INotifyPropertyChanged
    {
        //This class is declared as a list object in the KanbanBoardModel 
        //(The model to the KanbanBoard UI)

        //Each column in the board will have a list of associated cards
        //List of the KanbanCard class 
        public ObservableCollection<KanbanCard> column_cards { get; set; }

        //NOTE: The m is used on private variables to represent the fact that they are members of the class
        private string mcolumnName;
        private int mcolumnNumber;
        private int mcolumnId;

        public KanbanColumn()
        {
            ColumnName = "";
            ColumnNumber = 0;
            ColumnId = 0;
            column_cards = new ObservableCollection<KanbanCard>();
        }

        //Sample card
        public void AddCard(String cardName, int cardID, DateTime dueDate, int priority, String taskDescription, String assignee)
        {
            column_cards.Add(new KanbanCard { CardName = cardName, CardID = cardID, DueDate = dueDate, Priority = priority, TaskDescription = taskDescription, Assignee = assignee, ColumnId = this.ColumnId });
        }

        public void GetCardDetail(String cardName, int cardID, DateTime dueDate, int priority, String taskDescription, String assignee)
        {
            column_cards.Add(new KanbanCard { CardName = cardName, CardID = cardID, DueDate = dueDate, Priority = priority, TaskDescription = taskDescription, Assignee = assignee, ColumnId = this.ColumnId });
        }

        //Name of the column that should appear in the UI 
        public string ColumnName
        {
            get { return mcolumnName; }
            set { mcolumnName = value; }
        }

        //Starts at 0, the position of the column in the UI (0 -> n # columns)
        public int ColumnNumber
        {
            get { return mcolumnNumber; }
            set { mcolumnNumber = value; }
        }

        //Id of the column that will be referenced by a card 
        public int ColumnId
        {
            get { return mcolumnId; }
            set { mcolumnId = value; }
        }

        //Added property change notification for columns
        #region INotifyPropertyChanged Columns

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