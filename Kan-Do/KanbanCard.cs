using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do
{
    public class KanbanCard
    {
        //This class is instantiated 

        private string mcardName;
        private int mcardID;
        private DateTime mdueDate = new DateTime();
        private DateTime mdateCreated = new DateTime();
        private int mpriority;
        private string mtaskDescription;
        private string massignee;
        private int mcolumnId;

        public string CardName
        {
            get { return mcardName; }
            set { mcardName = value; }
        }

        public int CardID
        {
            get { return mcardID; }
            set { mcardID = value; }
        }

        public DateTime DueDate
        {
            get { return mdueDate; }
            set { mdueDate = value; }
        }

        public DateTime DateCreated
        {
            get { return mdateCreated; }
            set { mdateCreated = value; }
        }
        
        public int Priority
        {
            get { return mpriority; }
            set { mpriority = value; }
        }

        public string TaskDescription
        {
            get { return mtaskDescription; }
            set { mtaskDescription = value; }
        }

        public string Assignee
        {
            get { return massignee; }
            set { massignee = value; }
        }

        public int ColumnId
        {
            get { return mcolumnId; }
            set { mcolumnId = value; }
        }
    }
}
