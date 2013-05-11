using System.Collections.Generic;

namespace SolidPrinciples.ISP
{
    public class BookStats
    {
        private List<Book> books;

        public BookStats(List<Book> books)
        {
            this.books = books;
        }

        public virtual List<Book> GetBooksWithRating(int rating)
        {
            var booksWithRating = new List<Book>();

            foreach (var book in books)
            {
                if (book.GetRating() == rating)
                    booksWithRating.Add(book);
            }

            return booksWithRating;
        }
    }
}