using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice.models
{
    internal class book : Product
    {
        public string Genre;

        public book(string Genre, int No, string Name, int price, int count): base(No, Name, price, count)
        {
            this.Genre = Genre;
        }
    }
}
