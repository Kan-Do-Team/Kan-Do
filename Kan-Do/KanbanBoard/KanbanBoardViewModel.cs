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
            boardColumns.Add(new KanbanColumn { ColumnName = "To Do", ColumnNumber = 0, ColumnId = 1 });
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
                boardColumns.Add(new KanbanColumn { ColumnName = "Column Name", ColumnNumber = colNum, ColumnId = mcolId });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        //The saveColumn function is triggered by the saveColunn button in the UI
        //Since columns are created and filled with default values, this function will take in column data, find the associated column
        //In the columnlist, and update associated information 
        /*public void saveColumn(string columnname, int columnnumber, int columnid)
        {
            //Assume the saveColumn function can only be called once after the new column has been added to the list 
            //This is because a search on the list compares objects in the list, not elements in the objects 
            //KanbanColumn item = new KanbanColumn();

            //item.ColumnName = 


            //Search the List for the object that has the corresponding columnid
            /*foreach(KanbanColumn i in boardColumns)
            {
                if(boardColumns.)
            }

            KanbanColumn colItem = new KanbanColumn();
            colItem
            //First, find the index that has the given columnnumber
            boardColumns.Contains(KanbanColumn.ColumnNumber = columnnumber)*/

        //Once an item is deleted, the list needs to shift elements and adjust the columnNumber field (tells order in the UI)
        public void deleteColumn(int columnid)
        {
            //Find the element in the list that has the corresponding columnid
        }

        //public void sortColumn(int columnid, string sortType -- could also be an int, rep the type of sort)

        //public void moveColumn(int columnid, ------)

        //FUNCTIONS FOR CARDS

        //public void addCard(string cardname, int cardid, Date duedate, Date datecreated, String priority, string[] taskdescription, string assignee, int columnid)

        //public void deleteCard(int cardid)

        //public void moveCard(int cardid, int newcolumnid)






    }
}
