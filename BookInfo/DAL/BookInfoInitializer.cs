using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInfo.DAL
{
     public class BookInfoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookInfoContext>
  // public class BookInfoInitializer : System.Data.Entity.DropCreateDatabaseAlways<BookInfoContext>
     {
        protected override void Seed(BookInfoContext context)
        {
            var books = new List<Book>
            {
            new Book{Title="War and Peace", Year=DateTime.Parse("1869-09-01")},
            new Book{Title="The Borrowers", Year=DateTime.Parse("1945-09-01")},
            new Book{Title="Catcher in the Rye", Year=DateTime.Parse("1960-09-01")}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}