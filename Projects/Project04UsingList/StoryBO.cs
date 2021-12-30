using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project04UsingList
{
    class StoryBO
    {
		//created list method for author
		public List<Story> findStory(List<Story> storyList, string authorName)
		{
			storyList = storyList.Where(x => x.AuthorName == authorName).ToList();
			return storyList;
		}

		//create list for no of likes
		public List<Story> findStory(List<Story> storyList, int noOfLikes)
		{
			storyList = storyList.Where(x => x.NoOfLikes > noOfLikes).ToList();
			return storyList;
		}

	}
}
