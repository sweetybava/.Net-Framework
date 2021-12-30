using System;
using System.Collections.Generic;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            //fields
            int noOfStories;
            string storyDetails;

            //get user input
            Console.WriteLine("Enter the number of stories:");
            noOfStories = Convert.ToInt32(Console.ReadLine());

            //objects
            StoryBO storyBO = new StoryBO();
            Story[] storyDetailsArray = new Story[noOfStories];

            for (int i = 0; i < noOfStories; i++)
            {
                storyDetails = Console.ReadLine();

                string[] storyStringArray = storyDetails.Split(",");

                storyDetailsArray[i] = new Story(storyStringArray[0], storyStringArray[1], storyStringArray[2],
                    Convert.ToInt32(storyStringArray[3]), Convert.ToInt32(storyStringArray[4]), Convert.ToInt32(storyStringArray[5]));
            }


            Dictionary<string, int> dict = storyBO.getGenreWiseCount(storyDetailsArray);

            Console.WriteLine("Genre" + "        " + "Count");
            foreach (string k in dict.Keys)
            {
                Console.WriteLine(k + "          " + dict[k]);
            }
        }
    }
}