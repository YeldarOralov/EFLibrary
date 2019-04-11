using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student:Entity
    {
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
