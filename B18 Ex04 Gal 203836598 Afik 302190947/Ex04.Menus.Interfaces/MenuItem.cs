using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem : IChosenInvoker
    {
        private MenuItem m_ParentMenu;
        private string m_Title; 

        public MenuItem(string i_Title, MenuItem i_ParentMenu)
        {
            m_Title = i_Title;
            m_ParentMenu = i_ParentMenu;
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public MenuItem ParentMenu
        {
            get { return m_ParentMenu; }
            set { m_ParentMenu = value; }
        }

        public abstract void DoWhenChosen();
    }
}
