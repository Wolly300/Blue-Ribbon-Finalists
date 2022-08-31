using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Blue_Ribbon_Finalists
{
    public class Entry
    {
        private string _EntryName;
        private string _State;
        private string _Category;
        private string _PrepTime;
        private Image _Photo;
        private static int _ItemCount = 0;

        public Entry()
        {
            _ItemCount++;
        }

        public Entry(string EntryName, string State, string Category, string PrepTime, Image Photo)
        {
            _EntryName = EntryName;
            _State = State;
            _Category = Category;
            _PrepTime = PrepTime;
            _Photo = Photo;

            _ItemCount++;
        }


    }
}
