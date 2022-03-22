using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do
{
    internal class KanbanColumn
    {
        //This class is declared as a list object in the KanbanBoardModel 
        //(The model to the KanbanBoard UI)
        
        //NOTE: The m is used on private variables to represent the fact that they are members of the class
        private string mcolumnName;
        private int mcolumnNumber;
        private int mcolumnId;

        public string ColumnName
        {
            get { return mcolumnName; }
            set { mcolumnName = value;}
        }

        public int ColumnNumber
        {
            get { return mcolumnNumber; }
            set { mcolumnNumber = value;}
        }

        public int ColumnId
        {
            get { return mcolumnId; }
            set { mcolumnId = value; }
        }
    }
}
