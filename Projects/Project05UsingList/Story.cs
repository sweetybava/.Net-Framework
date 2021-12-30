using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05UsingList
{
   public class Story : IComparable
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
            this.name = name;
            this.authorName = authorName;
            this.genre = genre;
            this.noOfChapters = noOfChapters;
            this.noOfLikes = noOfLikes;
            this.noOfReads = noOfReads;
        }

        //properties
        public string Name { get => name; set => name = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NoOfChapters { get => noOfChapters; set => noOfChapters = value; }
        public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }
        public int NoOfReads { get => noOfReads; set => noOfReads = value; }


        //Comparable interface used to sort the values
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Story story = obj as Story;
            if (story != null)
            {
                return this.name.CompareTo(story.name);
            }
            else
            {
                // user defined exception
                throw new ArgumentException("Object doesn't have a proper price");
            }
        }

    }
}
