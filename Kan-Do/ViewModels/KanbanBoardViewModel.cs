using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Kan_Do.WPF.Views;
using Kan_Do.WPF.State.Navigators;
using System.Windows.Input;
using Kan_Do.WPF.Commands;
using Kan_Do.WPF.State.Authenticators;
using Kan_Do.Domain.Models;
using Kan_Do.WPF.State.SaveState;

namespace Kan_Do.WPF.ViewModels
{
    public class KanbanBoardViewModel : ViewModelBase
    {
        //This is where all of the functions that will be used in the UI, but require data in the model will be defined

        //Child view for card detail window
        private CardDetailWindowViewModel childViewModel;

        //Create a defintion of the model object 
        //public KanbanBoardModel KBoardModel;

        //List of the KanbanColumn class
        public ObservableCollection<KanbanColumn> boardColumns { get; set; }

        public int cardCount { get; set; }
        public int BoardId { get; set; }
        public GalaSoft.MvvmLight.Command.RelayCommand<object> ProcessCardDetails { get; set; }

        public IAuthenticator Authenticator { get; }
        public ISaveState SaveState { get; }
        public ICommand CardDropCommand { get; }
        public ICommand SaveCommand { get; }

        //ColumnId keeps track of the given columnId in the boardColumns list
        public int mcolId;
        private string boardName;
        public string BoardName
        {
            get
            {
                return boardName;
            }
            set 
            {
                boardName = value;
                OnPropertyChanged(nameof(BoardName));
            } 
        }

        //Constructor
        public KanbanBoardViewModel(IAuthenticator authenticator, ISaveState saveState)
        {
            Authenticator = authenticator;
            SaveState = saveState;
            SaveCommand = new SaveCommand(this, saveState);
            cardCount = 0;
            CardDropCommand = new CardDropCommand();
            boardColumns = new ObservableCollection<KanbanColumn>();
            ProcessCardDetails = new RelayCommand<object>(FetchCardDetails);
            Messenger.Default.Register<KanbanCard>(this, (action) => RecieveCardsDetails(action));

            //Initialize child view model
            childViewModel = new CardDetailWindowViewModel();
            //_navigator = navigator;
            BoardName = "Board Title";
        }


        //Function that fills the initial column values in the UI 
        //Default will be To Do, Doing and Done
        public void FillInitialColumns()
        {
            boardColumns.Add(new KanbanColumn { ColumnName = "TO DO", ColumnNumber = 0, ColumnId = 1 });
            boardColumns.Add(new KanbanColumn { ColumnName = "DOING", ColumnNumber = 1, ColumnId = 2 });
            boardColumns.Add(new KanbanColumn { ColumnName = "DONE", ColumnNumber = 2, ColumnId = 3 });
            mcolId = 3;
        }

        private object RecieveCardsDetails(KanbanCard selectcard)
        {
            //Add the object to the Card list in the column object
            var indexToUpdate = selectcard.ColumnId;
            boardColumns[indexToUpdate].column_cards.Add(selectcard);
            return null;
        }

        private void FetchCardDetails(object CommandParam)
        {
            var SelectedCardInfo = new CardDetailWindowViewModel
            {
                ColumnID = (int)(CommandParam)
            };

            var CardWindow = new CardDetailWindow(SelectedCardInfo.ColumnID);
            CardWindow.Show();
        }

        //FUNCTIONS FOR THE BOARD

        //public void saveBoard()

        //public void loadBoard(string filename)

        //public void addBoard(string boardName, string boardOwner)

        //public void deleteBoard(int boardid)

        //FUNCTIONS FOR COLUMNS

        //The addColumn button is triggered by the button click on the UI, it creates a new default column that the user can then
        //edit values in and save using the save column button on the UI 
        public void addColumn()
        {
            try
            {
                //Increment the columnId
                mcolId++;

                //Find the number of columns in the list to determine what the next columnNumber will be 
                int colNum = boardColumns.Count();
                //Count returns the number of elements, and since the columnNumber starts at 0, count will be the next col's position

                //Add a new column element to the list 
                boardColumns.Add(new KanbanColumn { ColumnName = "NEW COLUMN", ColumnNumber = colNum, ColumnId = mcolId });
                System.Diagnostics.Debug.WriteLine("Add column function success");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Add column function exception:", ex.ToString()); ;
            }
        }

        //Opens new card dialogue box and adds attributes
        public void cardDetails(int columnnumber)
        {
            try
            {
                ObservableCollection<KanbanCard> columnCardList = boardColumns[columnnumber].column_cards;
                CardDetailWindow view = new CardDetailWindow(columnnumber);
                //view.DataContext = childViewModel;
                view.ShowDialog();
                if (((CardDetailWindowViewModel)view.DataContext).closedWithSave)
                {
                    string cardName = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).cardName;
                    int cardID = cardCount;
                    DateTime dueDate = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).dueDate;
                    DateTime dateCreated = DateTime.Now;
                    int priority = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).priority;
                    string taskDescription = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).taskDescription;
                    string assignee = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).assignee;
                    int columnId = columnnumber + 1;
                    cardCount += 1;

                    boardColumns[columnnumber].column_cards.Add(new KanbanCard { CardName = cardName, CardID = cardID, DueDate = dueDate, DateCreated = dateCreated, Priority = priority, TaskDescription = taskDescription, Assignee = assignee, ColumnId = columnId });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Add card function exception:", ex.ToString()); ;
            }
        }

        public KanbanCard cardDetails(KanbanCard card)
        {
            try
            {
                CardDetailWindow view = new CardDetailWindow(card.ColumnId);
                //view.DataContext = childViewModel;
                ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).cardName = card.CardName;
                ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).dueDate = card.DueDate;
                ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).priority = card.Priority;
                ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).taskDescription = card.TaskDescription;
                ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).assignee = card.Assignee;   
                view.ShowDialog();
                if (((CardDetailWindowViewModel)view.DataContext).closedWithSave)
                {
                    card.CardName = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).cardName;
                    card.DueDate = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).dueDate;
                    card.Priority = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).priority;
                    card.TaskDescription = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).taskDescription;
                    card.Assignee = ((Kan_Do.WPF.ViewModels.CardDetailWindowViewModel)view.DataContext).assignee;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Add card function exception:", ex.ToString()); ;
            }
            return card;
        }

        //Once an item is deleted, the list needs to shift elements and adjust the columnNumber field (tells order in the UI)
        public void deleteColumn(int columnnumber)
        {
            try
            {
                //First check to see if we are deleting the last element
                if (columnnumber == boardColumns.Count-1)
                {
                    //Simply delete the last items of the collection, no adjustment to the columnNumber needed 
                    //Remove the element at the specified columnnumber (index)
                    boardColumns.RemoveAt(columnnumber);
                }
                else
                {
                    //The element is not the last index of the collection being removed 
                    //Start at the index after the one that is to be removed, decrease the columnNumber value of all subsequent
                    //Declare a list to make changes in the values 
                    List<KanbanColumn> list = new List<KanbanColumn>();
                    //Extract the items that come after the given columnNumber
                    list = boardColumns.Where(x => x.ColumnNumber > columnnumber).ToList();
                    //Remove the element at the specified columnnumber 
                    boardColumns.RemoveAt(columnnumber);
                    //Adjust the columnnumbers of all the elements in the list
                    int col = columnnumber;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (col < boardColumns.Count)
                        {
                            list[i].ColumnNumber = col;
                            boardColumns.RemoveAt(col);
                            //Place the list elements back into the observable collection (overwriting the previous values)
                            boardColumns.Insert(col, list[i]);
                            boardColumns[col].ColumnId = col + 1;
                            col++;
                        }
                    }
                }
                mcolId--;
                for (int i = columnnumber; i < boardColumns.Count; i++)
                {
                    for (int j = 0; j < boardColumns[i].column_cards.Count; j++)
                    {
                        boardColumns[i].column_cards[j].ColumnId = i+1;
                    }
                }

                System.Diagnostics.Debug.WriteLine("Shift column right function success");

                System.Diagnostics.Debug.WriteLine("Delete column function success");
            }

            catch (Exception ex) { System.Diagnostics.Debug.WriteLine("Delete column function exception:", ex.ToString()); }

        }

        //Check if column would violate board boundaries; if not then shift
        public void shiftColumnLeft(int columnnumber)
        {
            try
            {
                if (columnnumber > 0)
                {
                    boardColumns[columnnumber].ColumnNumber = columnnumber - 1;
                    boardColumns[columnnumber - 1].ColumnNumber = columnnumber;
                    boardColumns[columnnumber].ColumnId = columnnumber;
                    boardColumns[columnnumber - 1].ColumnId = columnnumber + 1;
                    boardColumns.Move(columnnumber, columnnumber - 1);
                    for (int i = 0; i < boardColumns[columnnumber].column_cards.Count; i++)
                    {
                        boardColumns[columnnumber].column_cards[i].ColumnId = columnnumber + 1;
                    }
                    for (int i = 0; i < boardColumns[columnnumber - 1].column_cards.Count; i++)
                    {
                        boardColumns[columnnumber - 1].column_cards[i].ColumnId = columnnumber;
                    }
                }
                

                System.Diagnostics.Debug.WriteLine("Shift column right function success");
                System.Diagnostics.Debug.WriteLine("Shift column left function success");
            }

            catch (Exception ex)
            {
                if (columnnumber > 0)
                {
                    boardColumns[columnnumber].ColumnNumber = columnnumber;
                    boardColumns[columnnumber - 1].ColumnNumber = columnnumber - 1;
                    boardColumns[columnnumber].ColumnId = columnnumber + 1;
                    boardColumns[columnnumber - 1].ColumnId = columnnumber;
                }
               
                System.Diagnostics.Debug.WriteLine("Shift colum left function exception:", ex.ToString()); ;
            }

        }

        public void shiftColumnRight(int columnnumber)
        {
            try
            {
                if (columnnumber < (boardColumns.Count() - 1))
                {
                    boardColumns[columnnumber].ColumnNumber = columnnumber + 1;
                    boardColumns[columnnumber + 1].ColumnNumber = columnnumber;
                    boardColumns[columnnumber].ColumnId = columnnumber + 2;
                    boardColumns[columnnumber + 1].ColumnId = columnnumber + 1;
                    boardColumns.Move(columnnumber, columnnumber + 1);
                    for (int i = 0; i < boardColumns[columnnumber].column_cards.Count; i++)
                    {
                        boardColumns[columnnumber].column_cards[i].ColumnId = columnnumber + 1;
                    }
                    for (int i = 0; i < boardColumns[columnnumber + 1].column_cards.Count; i++)
                    {
                        boardColumns[columnnumber + 1].column_cards[i].ColumnId = columnnumber + 2;
                    }
                }
                
                System.Diagnostics.Debug.WriteLine("Shift column right function success");
            }

            catch (Exception ex)
            {
                if (columnnumber < (boardColumns.Count() - 1))
                {
                    boardColumns[columnnumber].ColumnNumber = columnnumber;
                }
                System.Diagnostics.Debug.WriteLine("Shift column right function exception:", ex.ToString()); ;
            }

        }



        //public void sortColumn(int columnid, string sortType -- could also be an int, rep the type of sort)

        //public void moveColumn(int columnid, ------)

        //FUNCTIONS FOR CARDS

        //public void addCard(string cardname, int cardid, Date duedate, Date datecreated, String priority, string[] taskdescription, string assignee, int columnid)

        //public void deleteCard(int cardid)

        //public void moveCard(int cardid, int newcolumnid)

    }
}
