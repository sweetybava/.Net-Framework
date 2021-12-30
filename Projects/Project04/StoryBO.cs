using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project04
{
    class StoryBO
    {
        //array object
        Story[] stories = new Story[Program.noOfStory];

        //method (author)
        public Story[] findStoryByAuthor(Story[] listOfStory, string authorNameOfStory)
        {
            for (int i = 0; i < listOfStory.Length; i++)
            {
                if (listOfStory[i].AuthorName.Equals(authorNameOfStory))
                {
                    stories[i] = listOfStory[i];
                }
            }
            return stories;
        }

        //method (no. of list)
        public Story[] finfindStoryByLikes(Story[] listOfStory, int likesOfStory)
        {
            for (int i = 0; i < listOfStory.Length; i++)
            {
                if (listOfStory[i].NoOfLikes > likesOfStory)
                {
                    stories[i] = listOfStory[i];
                }
            }
            return stories;
        }
    }
}
