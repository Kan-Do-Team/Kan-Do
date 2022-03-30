using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.KanbanBoard
{
    public class KanbanBoardModel
    {
        //Defining all of the variables used in this class as private 
        //Each private variable will have it's own getter and setter to a public variable 

        //List of the KanbanCard class
        //public List<KanbanCard> boardCards;

        //List of the KanbanColumn class
        public List<KanbanColumn> boardColumns;


        //Constructor- initialize all objects/lists being used here
        public KanbanBoardModel()
        {
            boardColumns = new List<KanbanColumn>();
            //boardCards = new List<KanbanCard>();
        }
    }
}
