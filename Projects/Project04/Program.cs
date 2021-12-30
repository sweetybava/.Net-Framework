using System;

namespace Project04
{
    //main class
    class Program
    {
        public static int noOfStory;
        static void Main(string[] args)
        {
            //fields
            int noOfLikes;
            string storyDetails, authourName;

            //Get the user input
            Console.WriteLine("Enter the number of stories:");
            noOfStory = Convert.ToInt32(Console.ReadLine());

            //objects
            Story[] storyDetailsArray = new Story[noOfStory];
            Story[] findStoryList = new Story[] { };
            StoryBO storyBO = new StoryBO();


            for (int i = 0; i < noOfStory; i++)
            {

                storyDetails = Console.ReadLine();

                string[] storyStringArray = storyDetails.Split(",");

                storyDetailsArray[i] = new Story(storyStringArray[0], storyStringArray[1], storyStringArray[2],
                    Convert.ToInt32(storyStringArray[3]), Convert.ToInt32(storyStringArray[4]), Convert.ToInt32(storyStringArray[5]));
            }

            //get user input
            Console.WriteLine("Enter a search type: \n1.By author \n2.By number of likes");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the author name:");
                    authourName = Console.ReadLine();//.Trim();
                    findStoryList = storyBO.findStoryByAuthor(storyDetailsArray, authourName);
                    break;
                case 2:
                    Console.WriteLine("Enter the number of likes:");
                    noOfLikes = Convert.ToInt32(Console.ReadLine());
                    findStoryList = storyBO.finfindStoryByLikes(storyDetailsArray, noOfLikes);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            if (findStoryList.Length != 0 && findStoryList != null)
            {
                foreach (Story story in findStoryList)
                {
                    Console.WriteLine(story);
                }
            }
            else
            {
                Console.WriteLine("No such story is present");
            }

        }
    }
}

