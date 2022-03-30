using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Kan_Do.KanbanBoard
{
    public class KanbanBoardViewModel
    {
        //This is where all of the functions that will be used in the UI, but require data in the model will be defined

        //Create a defintion of the model object 
        //public KanbanBoardModel KBoardModel;

        //List of the KanbanColumn class
        public ObservableCollection<KanbanColumn> boardColumns;

        //ColumnId keeps track of the given columnId in the boardColumns list
        private int mcolId;

        //Constructor
        public KanbanBoardViewModel()
        {
            boardColumns = new ObservableCollection<KanbanColumn>();
            FillInitialColumns();
        }

        //Function that fills the initial column values in the UI 
        //Default will be To Do, Doing and Done
        public void FillInitialColumns()
        {
            boardColumns.Add(new KanbanColumn { ColumnName = "To Do", ColumnNumber = 0, ColumnId = 1});
            boardColumns.Add(new KanbanColumn { ColumnName = "Doing", ColumnNumber = 1, ColumnId = 2 });
            boardColumns.Add(new KanbanColumn { ColumnName = "Done", ColumnNumber = 2, ColumnId = 3 });
            mcolId = 3;
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
                boardColumns.Add(new KanbanColumn { ColumnName = "Column Name", ColumnNumber = colNum, ColumnId = mcolId});
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        //Once an item is deleted, the list needs to shift elements and adjust the columnNumber field (tells order in the UI)
        public void deleteColumn(int columnnumber)
        {
            try
            {
                //Start at the index after the one that will be removed
                //Change the columnnumber to columnnumber that is passed to the function

                //Change the columnnumber values of entries after the index that will be removed 
                /*int newcolnum = columnnumber;
                for(int i = columnnumber+1; i < boardColumns.Count; i++)
                {
                    KanbanColumn kcol = boardColumns.Item[i];
                    kcol.ColumnNumber = newcolnum;
                    boardColumns.Item[i] = kcol;
                    newcolnum++;
                }*/

                //Remove the element at the specified columnnumber 
                boardColumns.RemoveAt(columnnumber); 
            }

            catch(Exception ex) { System.Diagnostics.Debug.WriteLine(ex.ToString()); }

        }

        //public void sortColumn(int columnid, string sortType -- could also be an int, rep the type of sort)

        //public void moveColumn(int columnid, ------)

        //FUNCTIONS FOR CARDS

        //public void addCard(string cardname, int cardid, Date duedate, Date datecreated, String priority, string[] taskdescription, string assignee, int columnid)

        //public void deleteCard(int cardid)

        //public void moveCard(int cardid, int newcolumnid)






    }
}
