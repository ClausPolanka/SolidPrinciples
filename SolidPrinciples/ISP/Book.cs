using System;

namespace SolidPrinciples.ISP
{
    public class Book
    {
        private string title;
        private string author;
        private int yearPublished;
        private int ratingsCount;
        private float totalRating;

        public Book(string title, string author, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
        }

        public virtual string GetSummary()
        {
            return title + " by " + author + ", published " + yearPublished;
        }

        public virtual void Rate(int scoreOutOfFive)
        {
            ratingsCount++;
            totalRating += scoreOutOfFive;
        }

        public virtual int GetRating()
        {
            return (int) Math.Round(totalRating / ratingsCount);
        }
    }
}
