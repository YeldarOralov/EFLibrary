using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            var authors = new List<Author>();
            authors.Add(new Author {FullName= "Иван Иванов"});
            authors.Add(new Author {FullName= "Петр Петров" });
            authors.Add(new Author {FullName= "Сергей Сергеев"});

            var books = new List<Book>();
            books.Add(new Book { Name = "Сказки на ночь", Authors = new List<Author> {authors[0], authors[1]} });
            books.Add(new Book { Name = "Зеленая шапочка", Authors = new List<Author> {authors[1], authors[2]} });
            books.Add(new Book { Name = "Песик Гав-Гав", Authors = new List<Author> {authors[2], authors[0]} });

            var students = new List<Student>();
            students.Add(new Student { FullName = "Бека", Books = new List<Book> { books[0], books[1] } });
            students.Add(new Student { FullName = "Сека", Books = new List<Book> { books[2]} });
            students.Add(new Student { FullName = "Эрик", Books = new List<Book>()});

            //using (var context = new AppContext())
            //{
            //    context.Authors.AddRange(authors);
            //    context.Books.AddRange(books);
            //    context.Students.AddRange(students);
            //    context.SaveChanges();
            //}

            using (var context = new AppContext())
            {
                //context.Students.SqlQuery("Select * from Students s, StudentBooks sb where s.id = sb.student_id and sb.book_id is not null", new SqlParameter());
                //context.Students.
            }
            Console.Read();
        }
    }
}
