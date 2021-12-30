using System;
using System.Collections.Generic;
using System.Linq;


namespace Project05UsingList
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Enter the number of stories: ");
			int noOfStories = Convert.ToInt32(Console.ReadLine());

			//list
			List<Story> storyList = new List<Story>();

			for (int i = 0; i < noOfStories; i++)
			{
				string storyDetails = Console.ReadLine();
				storyList.Add(StoryBO.createStory(storyDetails));
			}
			Console.WriteLine("\nEnter a type to sort: \n1.sort by name \n2.sort by no.of Reads");
			int searchType = Convert.ToInt32(Console.ReadLine());

			switch (searchType)
			{
				case 1:
					storyList.Sort();
					break;
				case 2:
					NoOfReadsComparator noOfReadsComparator = new NoOfReadsComparator();
					storyList.Sort(noOfReadsComparator);
					break;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}

			Console.WriteLine("{0,5} {1,10} {2,15} {3,20} {4,25} {5,30}", "name", "authorName", "genre", "noOfChapters", "noOfLikes", "noOfReads");
			
			foreach (Story story in storyList)
			{
				Console.WriteLine("{0,5} {1,10} {2,15} {3,20} {4,25} {5,30}", story.Name, story.AuthorName, story.Genre, story.NoOfChapters, story.NoOfLikes, story.NoOfReads);
			}

		}
	}
}
