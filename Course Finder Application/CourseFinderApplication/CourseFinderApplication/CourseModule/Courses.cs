using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFinderApplication.UserModule;
using CourseFinderApplication.MenuModule;

//collection of classes
namespace CourseFinderApplication.CourseModule
{
	//courses to collect its behaviour and properties
	class Courses
    {

		//LinkedList<int> addToCourse = new LinkedList<int>();
		//LinkedList<String> addProductName = new LinkedList<String>();
		//LinkedList<CoursesBO> productList;

		//CoursesBO get = new CoursesBO(null);
		////	Login login = new Login();
		//bool Flag = true;
		

		public void availableCourses()
		{

			Console.WriteLine("\nAvailable Courses : \n");
			Console.WriteLine("\nPlease Select the Course Category:");
			Console.WriteLine("\nPress 1 for Data Science\nPress 2 for Machine Learning\nPress 3 for Artificial Intelligence\nPress 4 for IT and Software\nPress 5 for Cloud computing\nPress 6 for Exit\n");
			
			
			int choice = Convert.ToInt32(Console.ReadLine());

			switch (choice)
			{
				case 1:
					dataScience();
					break;

				case 2:
					machineLearnings();
					break;

				case 3:
					artificialIntelligence();
					break;

				case 4:
					itAndSoftware();
					break;

				case 5:
					cloudComputing();
					break;

				case 6:
					//Exit
					
					break;

				default:
					Console.WriteLine("Select according to the given numbers");
					availableCourses();
					break;
			}

		}

		//available courses
		//Course 1 - data science method
		void dataScience()
		{
			
			Console.WriteLine("\nData Science courses: (Beginner level, Intermediate level and Advanced level)");
			Console.WriteLine("press 1 for => Data Science Foundations");
			Console.WriteLine("press 2 for => Introduction to R");
			Console.WriteLine("press 3 for => Basics of Exploratory Data Analysis");
			Console.WriteLine("press 4 for => Probability for Data Science");
			Console.WriteLine("press 5 for => Data visualization using power BI");
			Console.Write("press 6 for => Exit\n");

			try
			{
				for (; ; )

				{
					int choice = Convert.ToInt32(Console.ReadLine());
					switch (choice)
					{
						case 1:
							//dataScienceFoundations();
							List<string> dataScienceFoundations = new List<string>();

							dataScienceFoundations.Add("Course Name      : Data Scine Foundations");
							dataScienceFoundations.Add("Course Level     : Beginner Level");
							dataScienceFoundations.Add("Duration         : 3 weeks");

							foreach (string objOne in dataScienceFoundations)
							{
								Console.WriteLine(objOne);
							}
							break;
						case 2:
							//introductionToR();
							List<string> introductionToR = new List<string>();

							introductionToR.Add("Course Name      : Introduction To R");
							introductionToR.Add("Course Level     : Intermediate Level");
							introductionToR.Add("Duration         : 2 weeks");

							foreach (string objTwo in introductionToR)
							{
								Console.WriteLine(objTwo);
							}
							
							break;
						case 3:
							//exploratoryDataAnalysis();
							List<string> exploratoryDataAnalysis = new List<string>();

							exploratoryDataAnalysis.Add("Course Name      : Exploratory Data Analysis");
							exploratoryDataAnalysis.Add("Course Level     : Advanced Level");
							exploratoryDataAnalysis.Add("Duration         : 4 weeks");

							foreach (string objThree in exploratoryDataAnalysis)
							{
								Console.WriteLine(objThree);
							}
							break;
						case 4:
							//probabilityDataScience();
							List<string> probabilityDataScience = new List<string>();

							probabilityDataScience.Add("Course Name      : Probability Data Science");
							probabilityDataScience.Add("Course Level     : Intermediate Level");
							probabilityDataScience.Add("Duration         : 1 week");
							
							foreach (string objFour in probabilityDataScience)
							{
								Console.WriteLine(objFour);
							}
							break;
						case 5:
							//dataVisualisation();
							List<string> dataVisualisation = new List<string>();

							dataVisualisation.Add("Course Name      : Data Visualisation");
							dataVisualisation.Add("Course Level     : Beginner Level");
							dataVisualisation.Add("Duration         : 1 week");

							foreach (string objFive in dataVisualisation)
							{
								Console.WriteLine(objFive);
							}
							break;
						case 6:
							//Exit
							availableCourses();
							break;
						default:
							Console.WriteLine("You can only choose according to the given numbers");
							break;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You can only choose according to the given numbers");
				dataScience();
			}
		}

		//Course 2 -  method
		void machineLearnings()
		{

			Console.WriteLine("\nMachine Learning courses: (Beginner level, Intermediate level and Advanced level)");
			Console.WriteLine("press 1 for => Basics of Machine Learning");
			Console.WriteLine("press 2 for => Python for machine learning");
			Console.WriteLine("press 3 for => Data visualization using python");
			Console.WriteLine("press 4 for => Statistics for machine learning");
			Console.WriteLine("press 5 for => Supervised machine learning");
			Console.Write("press 6 for Exit\n");

			try
			{
				for (; ; )

				{
					int choice = Convert.ToInt32(Console.ReadLine());
					switch (choice)
					{
						case 1:
							//basicsOfMachineLearning();
							List<string> basicsOfMachineLearning = new List<string>();

							basicsOfMachineLearning.Add("Course Name      : Basics of Machine Learning");
							basicsOfMachineLearning.Add("Course Level     : Beginner Level");
							basicsOfMachineLearning.Add("Duration         : 1 week");

							foreach (string coursesOne in basicsOfMachineLearning)
							{
								Console.WriteLine(coursesOne);
							}
							break;
						case 2:
							//pythonForMachineLearning();
							List<string> pythonForMachineLearning = new List<string>();

							pythonForMachineLearning.Add("Course Name      : Python For Machine Learning");
							pythonForMachineLearning.Add("Course Level     : Intermediate Level");
							pythonForMachineLearning.Add("Duration         : 2 weeks");

							foreach (string coursesTwo in pythonForMachineLearning)
							{
								Console.WriteLine(coursesTwo);
							}
							break;
						case 3:
							//dataVisualizationUsingPython();
							List<string> dataVisualizationUsingPython = new List<string>();

							dataVisualizationUsingPython.Add("Course Name      : Data Visualization using python");
							dataVisualizationUsingPython.Add("Course Level     : Intermediate Level");
							dataVisualizationUsingPython.Add("Duration         : 2 weeks");

							foreach (string coursesThree in dataVisualizationUsingPython)
							{
								Console.WriteLine(coursesThree);
							}
							break;
						case 4:
							//statisticsForMachineLearning();
							List<string> statisticsForMachineLearning = new List<string>();

							statisticsForMachineLearning.Add("Course Name      : Statistics for machine learning");
							statisticsForMachineLearning.Add("Course Level     : Advanced Level");
							statisticsForMachineLearning.Add("Duration         : 4 weeks");

							foreach (string coursesFour in statisticsForMachineLearning)
							{
								Console.WriteLine(coursesFour);
							}
							break;
						case 5:
							//supervisedMachineLearning();
							List<string> supervisedMachineLearning = new List<string>();

							supervisedMachineLearning.Add("Course Name      : Supervised For Machine ");
							supervisedMachineLearning.Add("Course Level     : Beginner Level");
							supervisedMachineLearning.Add("Duration         : 1 week");

							foreach (string coursesFive in supervisedMachineLearning)
							{
								Console.WriteLine(coursesFive);
							}
							break;
						case 6:
							//Exit (It call the available courses list again)
							availableCourses();
							break;
						default:
							Console.WriteLine("You can only choose according to the given numbers");
							break;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You can only choose according to the given numbers");
				machineLearnings();
			}
		}

		//Course 3 -  method
		void artificialIntelligence()
		{

			Console.WriteLine("\nArtificial Intelligence courses: (Beginner level, Intermediate level and Advanced level)");
			Console.WriteLine("press 1 for => Introduction to Deep Learning");
			Console.WriteLine("press 2 for => Introduction to Neural networks and Deep learning");
			Console.WriteLine("press 3 for => Digital image processing");
			Console.WriteLine("press 4 for => Natural image processing");
			Console.WriteLine("press 5 for => Building Recommendation system");
			Console.Write("press 6 for => Exit");

			try
			{
				for (; ; )

				{
					int choice = Convert.ToInt32(Console.ReadLine());
					switch (choice)
					{
						case 1:
							//deepLearning();
							List<string> deepLearning = new List<string>();

							deepLearning.Add("Course Name      : Deep Learning");
							deepLearning.Add("Course Level     : Beginner Level");
							deepLearning.Add("Duration         : 2 weeks");

							foreach (string DLOne in deepLearning)
							{
								Console.WriteLine(DLOne);
							}
							break;
						case 2:
							//neuralNetworks();
							List<string> neuralNetworks = new List<string>();

							neuralNetworks.Add("Course Name      : Neural Networks");
							neuralNetworks.Add("Course Level     : Intermediate Level");
							neuralNetworks.Add("Duration         : 3 weeks");

							foreach (string DLTwo in neuralNetworks)
							{
								Console.WriteLine(DLTwo);
							}

							break;
						case 3:
							//digitalImageProcessing();
							List<string> digitalImageProcessing = new List<string>();

							digitalImageProcessing.Add("Course Name      : Digital Image Processing");
							digitalImageProcessing.Add("Course Level     : Beginner Level");
							digitalImageProcessing.Add("Duration         : 2 weeks");

							foreach (string DLThree in digitalImageProcessing)
							{
								Console.WriteLine(DLThree);
							}

							break;
						case 4:
							//naturalLanguageProcessing();
							List<string> nLP = new List<string>();

							nLP.Add("Course Name      : Natural Language Processing");
							nLP.Add("Course Level     : Advanced Level");
							nLP.Add("Duration         : 5 weeks");

							foreach (string DLFour in nLP)
							{
								Console.WriteLine(DLFour);
							}
							break;
						case 5:
							//buildingRecommendationSystem();
							List<string> bRS = new List<string>();

							bRS.Add("Course Name      : Building Recomendation System");
							bRS.Add("Course Level     : Advanced Level");
							bRS.Add("Duration         : 4 weeks");

							foreach (string DLFive in bRS)
							{
								Console.WriteLine(DLFive);
							}

							break;
						case 6:
							//Exit
							availableCourses();
							break;
						default:
							Console.WriteLine("You can only choose according to the given numbers");
							break;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You can only choose according to the given numbers");
				artificialIntelligence();
			}
		}

		//Course 4 -  method
		void itAndSoftware()
		{

			Console.WriteLine("\nIT and Software courses: (Beginner level, Intermediate level and Advanced level)");
			Console.WriteLine("press 1 for => Java Programming");
			Console.WriteLine("press 2 for => Introduction to programming");
			Console.WriteLine("press 3 for => Frontend development");
			Console.WriteLine("press 4 for => Blockchain basics");
			Console.WriteLine("press 5 for => Data structures in C");
			Console.Write("press 6 for => Exit");

			try
			{
				for (; ; )

				{
					int choice = Convert.ToInt32(Console.ReadLine());
					switch (choice)
					{
						case 1:
							//javaProgramming();
							List<string> javaProgramming = new List<string>();

							javaProgramming.Add("Course Name      : Java Programming");
							javaProgramming.Add("Course Level     : Beginner Level");
							javaProgramming.Add("Duration         : 2 weeks");

							foreach (string ITSOne in javaProgramming)
							{
								Console.WriteLine(ITSOne);
							}

							break;
						case 2:
							//introductionToProgramming();
							List<string> ITProgram = new List<string>();

							ITProgram.Add("Course Name      : Introduction to Programming");
						    ITProgram.Add("Course Level     : Beginner Level");
							ITProgram.Add("Duration         : 1 weeks");

							foreach (string ITSTwo in ITProgram)
							{
								Console.WriteLine(ITSTwo);
							}
							break;
						case 3:
							//frontendDevelopment();
							List<string> fED = new List<string>();

							fED.Add("Course Name      : Frontend Development");
							fED.Add("Course Level     : Intermediate Level");
							fED.Add("Duration         : 3 weeks");

							foreach (string ITSThree in fED)
							{
								Console.WriteLine(ITSThree);
							}

							break;
						case 4:
							//blockchainBasics();
							List<string>bcBasics = new List<string>();

							bcBasics.Add("Course Name      : Bloc chain basics");
							bcBasics.Add("Course Level     : Advanced Level");
							bcBasics.Add("Duration         : 5 weeks");

							foreach (string ITSFour in bcBasics)
							{
								Console.WriteLine(ITSFour);
							}

							break;
						case 5:
							//dataStructuresInC();
							List<string> dataStructuresInC = new List<string>();

							dataStructuresInC.Add("Course Name      : Data Structures InC");
							dataStructuresInC.Add("Course Level     : Advanced Level");
							dataStructuresInC.Add("Duration         : 2 weeks");

							foreach (string ITSFive in dataStructuresInC)
							{
								Console.WriteLine(ITSFive);
							}

							break;
						case 6:
							//Exit
							availableCourses();
							break;
						default:
							Console.WriteLine("You can only choose according to the given numbers");
							break;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You can only choose according to the given numbers");
				itAndSoftware();
			}
		}

		//Course 5 -  method
		void cloudComputing()
		{

			Console.WriteLine("\nCloud Computing courses: (Beginner level, Intermediate level and Advanced level)");
			Console.WriteLine("press 1 for => Google cloud platform");
			Console.WriteLine("press 2 for => Microsoft Azure applications");
			Console.WriteLine("press 3 for => Cloud computing service models");
			Console.WriteLine("press 4 for => Cloud foundations");
			Console.WriteLine("press 5 for => Applications of Cloud Computing");
			Console.Write("press 6 for => Exit");

			try
			{
				for (; ; )

				{
					int choice = Convert.ToInt32(Console.ReadLine());
					switch (choice)
					{
						case 1:
							//googleCloudPlatform();
							List<string> gcp = new List<string>();

							gcp.Add("Course Name      : Google Cloud Platform");
							gcp.Add("Course Level     : Beginner Level");
							gcp.Add("Duration         : 2 weeks");

							foreach (string CLOne in gcp)
							{
								Console.WriteLine(CLOne);
							}

							break;
						case 2:
							//microsoftAzureApplication();
							List<string> mAA = new List<string>();

							mAA.Add("Course Name      : Microsoft Azure Application");
							mAA.Add("Course Level     : Beginner Level");
							mAA.Add("Duration         : 2 weeks");

							foreach (string CLTwo in mAA)
							{
								Console.WriteLine(CLTwo);
							}

							break;
						case 3:
							//cloudComputingService();
							List<string> ccs = new List<string>();

							ccs.Add("Course Name      : Cloud Computing Services");
							ccs.Add("Course Level     : Intermediiate Level");
							ccs.Add("Duration         : 3 weeks");

							foreach (string CLThree in ccs)
							{
								Console.WriteLine(CLThree);
							}

							break;
						case 4:
							//cloudFoundations();
							List<string> cloudFoundation = new List<string>();

							cloudFoundation.Add("Course Name      : Cloud Foundation");
							cloudFoundation.Add("Course Level     : Advanced Level");
							cloudFoundation.Add("Duration         : 5 weeks");

							foreach (string CLFour in cloudFoundation)
							{
								Console.WriteLine(CLFour);
							}

							break;
						case 5:
							//applicationsOfCloudComputing();
							List<string> aCloudComputing = new List<string>();

							aCloudComputing.Add("Course Name      : Application Cloud COmputing");
							aCloudComputing.Add("Course Level     : Advanced Level");
							aCloudComputing.Add("Duration         : 5 weeks");

							foreach (string CLFive in aCloudComputing)
							{
								Console.WriteLine(CLFive);
							}

							break;
						case 6:
							//Exit
							availableCourses();
							break;
						default:
							Console.WriteLine("You can only choose according to the given numbers");
							break;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You can only choose according to the given numbers");
				cloudComputing();
			}
		}
	}
}
