using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Models
{
    public class Board : DomainObject
    {
        public string BoardName { get; set; }
        public Account BoardCreator { get; set; }
    }
}
