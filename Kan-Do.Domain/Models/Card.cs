using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Models
{
    public class Card : DomainObject
    {
        public int CardReferenceNumber { get; set; }
        public string CardName { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public int Priority { get; set; }
        public string TaskDescription { get; set; }
        public string Assignee { get; set; }
        public Column Column { get; set; }
    }
}
