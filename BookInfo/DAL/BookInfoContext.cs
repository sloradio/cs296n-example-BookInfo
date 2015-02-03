using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookInfo.DAL
{
    public class BookInfoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}