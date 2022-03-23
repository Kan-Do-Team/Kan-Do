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
        public KanbanBoardModel KBoardModel; 
        

        //Constructor
        public KanbanBoardViewModel()
        {
            KBoardModel = new KanbanBoardModel();
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
