using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Collection of classes
namespace CourseFinderApplication.CourseModule
{
	//CoursesBo class to collect its behaviour and properties
	public class CoursesBO
    {
		string courseName;
		public CoursesBO(String courseName)
		{
			///super();
			this.courseName = courseName;
		}

		public CoursesBO()
		{
			// TODO Auto-generated constructor stub
		}


		public String getCourseName()
		{
			return courseName;
		}

		public void setCourseName(String courseName)
		{
			this.courseName = courseName;
		}

		/*
		public static Story createStory(String detail)
		{
			string[] str = detail.Split(",");

			Story story = new Story(str[0], str[1], str[2], Convert.ToInt32(str[3]), Convert.ToInt32(str[4]), Convert.ToInt32(str[5]));

			return story;

		}
		*/
		

	}
}
