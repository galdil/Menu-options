using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowTime : MenuItem
    {
        public ShowTime(string i_Title, MenuItem i_ParentMenu)
            : base(i_Title, i_ParentMenu) { }

        public override void DoWhenChosen()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }
}
