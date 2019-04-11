using System.Collections.Generic;

namespace Library
{
    public class Book:Entity
    {
        public string Name { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}