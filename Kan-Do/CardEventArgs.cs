using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do
{
    public class CardEventArgs: EventArgs
    {
        private string text;

        public CardEventArgs(string text)
        {
            this.text = text;
        }

        //Read-only propert
        public string Text
        {
            get { return text; }
        }
    }
}
