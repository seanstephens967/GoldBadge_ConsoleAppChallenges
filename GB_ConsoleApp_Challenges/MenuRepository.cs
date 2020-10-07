using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_ConsoleApp_Challenges
{
    public class MenuRepository
    {
        List<MenuContent> _menuDirectory = new List<MenuContent>();

        //Create
        public void AddToMenu(MenuContent meal)
        {
            _menuDirectory.Add(meal);
        }
        //Read
        public List<MenuContent> ShowAllMenuItems()
        {
            return _menuDirectory;
        }
        //Read Items by ingredient 

        //Delete
        public void DeleteMenuItem(MenuContent deleteContent)
        {
            _menuDirectory.Remove(deleteContent);
        }
    }
}
