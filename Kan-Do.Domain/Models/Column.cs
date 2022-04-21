using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Models
{
    public class Column : DomainObject
    {
        public string ColumnName { get; set; }
        public int Position { get; set; }
        public Board Board { get; set; }
    }
}
