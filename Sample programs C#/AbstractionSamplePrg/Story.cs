using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionSamplePrg
{
    //abstract class
    abstract class Story
    {
        //abstract method - does not have the body
        public abstract void storyTitle();

        //normal method
        public void storyAuthorName()
        {
            Console.WriteLine("Author Name : Peter Sohn");
        }
        
    }

    //StoryContent class inherit the abstract Story class
    class StoryContent : Story
    {
        //override the abstract method
        public override void storyTitle()
        {
            Console.WriteLine("Title: The Good Dinosaur");
        }
    }
}
