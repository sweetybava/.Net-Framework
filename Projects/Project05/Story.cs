using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05
{
    //Story class implement the comparable interface
    //Comparable interface used to compare the values
    class Story : IComparable
    {

        //fields
        private string name, authorName, genre;
        private int noOfChapters, noOfLikes, noOfReads;

        //Default constructor
        public Story()
        {

        }

        //parameterized constructor
        public Story(string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.NoOfChapters = noOfChapters;
            this.NoOfLikes = noOfLikes;
            this.NoOfReads = noOfReads;
        }

        //Properties
        public string Name { get => name; set => name = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NoOfChapters { get => noOfChapters; set => noOfChapters = value; }
        public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }
        public int NoOfReads { get => noOfReads; set => noOfReads = value; }

        //Using comparable interface - compare the stories name
        public int CompareTo(object obj)
        {
            Story story = (Story)obj;
            return this.Name.CompareTo(story.Name);
        }

        public override string ToString()
        {
            return string.Format(this.Name + " " + " " + this.AuthorName + " " + this.Genre
                + " " + this.NoOfChapters + " " + this.NoOfLikes + " " + this.NoOfReads);
        }

    }
}
