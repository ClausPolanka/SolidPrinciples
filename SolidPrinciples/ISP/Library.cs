using System.Collections.Generic;

namespace SolidPrinciples.ISP
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public virtual List<Book> GetBooks()
        {
            return books;
        }

        public virtual void AddBook(Book book)
        {
            books.Add(book);
        }

        public virtual string DumpContents()
        {
            var dump = "";

            for (int i = 0; i < books.Count; i++)
            {
                dump += books[i].GetSummary();
                
                if (i != books.Count)
                    dump += "\\n";
            }

            return dump;
        }
    }
}