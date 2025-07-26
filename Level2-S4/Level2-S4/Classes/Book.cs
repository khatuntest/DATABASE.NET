using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2_S4.Classes
{
    public  class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not Book) 
                return false;
            Book book2 = obj as Book;
            return this.Title == book2.Title && this.Author == book2.Author;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title,Author);
        }
        public override string ToString()
        {
            return $"The Title is {Title} and Author {Author}";
        }
    }
}
