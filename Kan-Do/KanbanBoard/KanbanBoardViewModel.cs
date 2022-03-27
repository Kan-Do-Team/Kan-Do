using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.KanbanBoard
{
    public class KanbanBoardViewModel
    {
        //This is where all of the functions that will be used in the UI, but require data in the model will be defined

        //Create a defintion of the model object 
        //public KanbanBoardModel KBoardModel;

        //List of the KanbanColumn class
        public List<KanbanColumn> boardColumns;

        //Constructor
        public KanbanBoardViewModel()
        {
            boardColumns = new List<KanbanColumn>();
            FillInitialColumns();
        }

        //Function that fills the initial column values in the UI 
        //Default will be To Do, Doing and Done
        public void FillInitialColumns()
        {
            //Initialize a column type element to add to the list 
            KanbanColumn colelement = new KanbanColumn();
            
            //First column type, To Do
            colelement.ColumnName = "To Do";
            colelement.ColumnNumber = 0;
            colelement.ColumnId = 1;
            boardColumns.Add(colelement);

            //Second column type, Doing 
            colelement.ColumnName = "Doing";
            colelement.ColumnNumber = 1;
            colelement.ColumnId = 2;
            boardColumns.Add(colelement);

            //Third column type, Done
            colelement.ColumnName = "Done";
            colelement.ColumnNumber= 2;
            colelement.ColumnId = 3;
            boardColumns.Add(colelement);
        }


        //FUNCTIONS FOR THE BOARD

        //public void saveBoard()

        //public void loadBoard(string filename)

        //public void addBoard(string boardName, string boardOwner)

        //public void deleteBoard(int boardid)

        //FUNCTIONS FOR COLUMNS

        //public void addColumn(string columname, int columnnumber, int columnid)

        //public void moveColumn(int columnid, ------)

        //public void deleteColumn(int columnid)

        //public void sortColumn(int columnid, string sortType -- could also be an int, rep the type of sort)


        //FUNCTIONS FOR CARDS

        //public void addCard(string cardname, int cardid, Date duedate, Date datecreated, String priority, string[] taskdescription, string assignee, int columnid)

        //public void deleteCard(int cardid)

        //public void moveCard(int cardid, int newcolumnid)






    }
}
