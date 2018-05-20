using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class CountCapitals : MenuItem
    {
        public CountCapitals(string i_Title, MenuItem i_ParentMenu)
            : base(i_Title, i_ParentMenu) { }

        public override void DoWhenChosen()
        {
            Console.WriteLine("Please enter a sentence:");
            string userSentence = Console.ReadLine();
            Console.WriteLine(countCapitals(userSentence));
        }

        private int countCapitals(string i_Sentence)
        {
            int counter = 0;
            for (int i = 0; i < i_Sentence.Length; i++)
            {
                if (char.IsUpper(i_Sentence[i]))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
