using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppContext())
            {
                var author = new Author
                {
                    FullName = "Пушкин.А.С"
                };

                var book = new Book
                {
                    Name = "Сказки",
                    Price = 1000,
                    Author = author
                };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}
