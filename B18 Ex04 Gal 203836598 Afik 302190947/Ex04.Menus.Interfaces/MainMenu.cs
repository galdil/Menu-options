using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface IChosenInvoker 
    {
        void DoWhenChosen();
    }
    public class MainMenu : MenuItem
    {
        private List<MenuItem> m_MenuList;
        public MainMenu(string i_Title, MenuItem i_ParentMenu)
            : base(i_Title, i_ParentMenu)
        {
            m_MenuList = new List<MenuItem>();
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            m_MenuList.Add(i_MenuItem);
        }

        public void RemoveItem(MenuItem i_ItemToRemove)
        {
            m_MenuList.Remove(i_ItemToRemove);
        }

        public void Show()
        {
            StringBuilder menuToShow = new StringBuilder(m_Title + "\n");
            MenuItem currentItem;
            for (int i = 0; i < m_MenuList.Count; i++)
            {
                currentItem = m_MenuList[i];
                menuToShow.AppendFormat("{0}. {1}", i + 1, currentItem.Title);
            }

            Console.WriteLine(menuToShow.ToString());
        }

    }
}
