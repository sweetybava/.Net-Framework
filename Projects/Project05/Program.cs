using System;

namespace Project05
{
    class Program
    {
        static void Main(string[] args)
        {
            //fields
            int noOfStories;
            string storyDetails;

            // Get the user input 
            Console.WriteLine("Enter the number of the stories:");
            noOfStories = Convert.ToInt32(Console.ReadLine());

            //objects
            NoOfReadsComparator noOfReadsComparator = new NoOfReadsComparator();
            Story[] storyDetailsArray = new Story[noOfStories];

            for (int i = 0; i < noOfStories; i++)
            {

                storyDetails = Console.ReadLine();

                storyDetailsArray[i] = StoryBO.createStory(storyDetails);
            }

            Console.WriteLine("Enter a type to sort: \n1.Sort by Name \n2.Sort by No. of Reads");
            int choices = Convert.ToInt32(Console.ReadLine());

            switch (choices)
            {
                case 1:
                    //Sorting the array values using name of the story
                    Array.Sort(storyDetailsArray);
                    break;
                case 2:
                    //Sorting the array values using no.of reads of the story
                    Array.Sort(storyDetailsArray, noOfReadsComparator);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            foreach (Story story in storyDetailsArray)
            {
                Console.WriteLine(story);
            }

        }
    }
}
