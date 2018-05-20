using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_SubMenuList;
        public SubMenu(string i_Title, MenuItem i_ParentMenu)
            :base(i_Title, i_ParentMenu)
        {
            m_SubMenuList = new List<MenuItem>();
        }

        public List<MenuItem> SubMenuList
        {
            get { return m_SubMenuList; }
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            m_SubMenuList.Add(i_MenuItem);
        }

        public void RemoveItem(MenuItem i_ItemToRemove)
        {
            m_SubMenuList.Remove(i_ItemToRemove);
        }

        public override void DoWhenChosen()
        {
            Ex02.ConsoleUtils.Screen.Clear();
            Console.WriteLine(string.Format(@"Parent menu: {0} 
0. Back" , ParentMenu.Title));
            StringBuilder menuToShow = new StringBuilder();
            MenuItem currentItem;
            for (int i = 0; i <= m_SubMenuList.Count; i++)
            {
                currentItem = m_SubMenuList[i];
                menuToShow.AppendFormat("{0}. {1}", i+1, currentItem.Title);
            }

            Console.WriteLine(menuToShow.ToString());
        }
    }
}
