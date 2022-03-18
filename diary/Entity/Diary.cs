using diary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace diary
{
    public class Diary
    {

        public Person Person
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public string ImageUrl
        {
            get;
            set;
        }

        public int Point
        {
            get;
            set;
        }
    }
}
