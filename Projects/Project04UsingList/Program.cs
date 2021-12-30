using System;
using System.Collections.Generic;
using System.Linq;


namespace Project04UsingList
{
	class Program
	{
		static void Main(string[] args)
		{

			//Get user input
			Console.WriteLine("Enter the number of stories: ");
			int noOfStories = Convert.ToInt32(Console.ReadLine());

			//create list
			List<Story> storyList = new List<Story>();
			List<Story> outputStoryList = new List<Story>();
			StoryBO stroyBO = new StoryBO();

			for (int i = 0; i < noOfStories; i++)
			{
				string storyDetails = Console.ReadLine();
				string[] values = storyDetails.Split(',');
				Story story = new Story(values[0], values[1], values[2], Convert.ToInt32(values[3]), Convert.ToInt32(values[4]), Convert.ToInt32(values[5]));
				storyList.Add(story);
			}


			Console.WriteLine("Enter a search type: \n1.By author \n2.By number of likes");
			int searchType = Convert.ToInt32(Console.ReadLine());
			
			//Get and print the user details based on the requirement
			switch (searchType)
			{
				case 1:
					Console.WriteLine("Enter the author Name");
					string authorName = Console.ReadLine();
					outputStoryList = stroyBO.findStory(storyList, authorName);
					break;
				case 2:
					Console.WriteLine("Enter the no of likes");
					int noOfLikes = Convert.ToInt32(Console.ReadLine());
					outputStoryList = stroyBO.findStory(storyList, noOfLikes);
					break;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}

			if (outputStoryList.Count() == 0)
			{
				Console.WriteLine("No such story is present");
			}
			else
			{
				Console.WriteLine("{0,5} {1,10} {2,15} {3,20} {4,25} {5,30}", "name", "authorName", "genre", "noOfChapters", "noOfLikes", "noOfReads");
				foreach (Story story in outputStoryList)
				{
					Console.WriteLine("{0,5} {1,10} {2,15} {3,20} {4,25} {5,30}", story.Name, story.AuthorName, story.Genre, story.NoOfChapters, story.NoOfLikes, story.NoOfReads);
				}

			}
		}

	}
}
