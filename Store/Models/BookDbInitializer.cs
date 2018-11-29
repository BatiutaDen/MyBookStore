using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Store.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { BookName = "Думай и богатей", BookAuthor = "Наполеон Хил", price = 330 });
            db.Books.Add(new Book { BookName = "Унесенные ветром", BookAuthor = "Маргарет Митчелл", price = 180 });
            db.Books.Add(new Book { BookName = "Код да Винчи", BookAuthor = "Дэн Браун", price = 120 });

            base.Seed(db);
        }
    }
}