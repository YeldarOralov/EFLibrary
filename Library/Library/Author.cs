using System.Collections.Generic;

namespace Library
{
    public class Author:Entity
    {
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
