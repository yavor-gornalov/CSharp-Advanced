﻿namespace IteratorsAndComparators
{
    public class Book :IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public int CompareTo(Book? other)
        {
            if (this.Year != other.Year) 
                return this.Year.CompareTo(other.Year);
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString() =>  $"{this.Title} - {this.Year}";

    }
}
