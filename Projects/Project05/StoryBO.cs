using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05
{
    class StoryBO
    {

        public static Story createStory(String detail)
        {
            string[] s1 = detail.Split(",");

            Story story = new Story(s1[0], s1[1], s1[2], Convert.ToInt32(s1[3]), Convert.ToInt32(s1[4]), Convert.ToInt32(s1[5]));

            return story;

        }
    }
}
