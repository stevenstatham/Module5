using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_encoder
{
	class ClassURL
	{
		protected string projectName;
		protected string activityName;
		public ClassURL(string p, string a)
		{
			projectName = p;
			activityName = a;
		}
		public void fixURL()
		{
			projectName = projectName.Replace("%", "%25");
			projectName = projectName.Replace(" ", "%20");
			projectName = projectName.Replace("<", "%3C");
			projectName = projectName.Replace(">", "%3E");
			projectName = projectName.Replace("#", "%23");
			projectName = projectName.Replace("\"", "%22");
			projectName = projectName.Replace(";", "%3B");
			projectName = projectName.Replace("/", "%2F");
			projectName = projectName.Replace("?", "%3F");
			projectName = projectName.Replace(":", "%3A");
			projectName = projectName.Replace("@", "%40");
			projectName = projectName.Replace("&", "%26");
			projectName = projectName.Replace("=", "%3D");
			projectName = projectName.Replace("+", "%2B");
			projectName = projectName.Replace("$", "%24");
			projectName = projectName.Replace("{", "%7B");
			projectName = projectName.Replace("}", "%7D");
			projectName = projectName.Replace("|", "%7C");
			projectName = projectName.Replace("\\", "%5C");
			projectName = projectName.Replace("^", "%5E");
			projectName = projectName.Replace("[", "%5B");
			projectName = projectName.Replace("]", "%5D");
			projectName = projectName.Replace("`", "%60");
			activityName = activityName.Replace("%", "%25");
			activityName = activityName.Replace(" ", "%20");
			activityName = activityName.Replace("<", "%3C");
			activityName = activityName.Replace(">", "%3E");
			activityName = activityName.Replace("#", "%23");
			activityName = activityName.Replace("\"", "%22");
			activityName = activityName.Replace(";", "%3B");
			activityName = activityName.Replace("/", "%2F");
			activityName = activityName.Replace("?", "%3F");
			activityName = activityName.Replace(":", "%3A");
			activityName = activityName.Replace("@", "%40");
			activityName = activityName.Replace("&", "%26");
			activityName = activityName.Replace("=", "%3D");
			activityName = activityName.Replace("+", "%2B");
			activityName = activityName.Replace("$", "%24");
			activityName = activityName.Replace("{", "%7B");
			activityName = activityName.Replace("}", "%7D");
			activityName = activityName.Replace("|", "%7C");
			activityName = activityName.Replace("\\", "%5C");
			activityName = activityName.Replace("^", "%5E");
			activityName = activityName.Replace("[", "%5B");
			activityName = activityName.Replace("]", "%5D");
			activityName = activityName.Replace("`", "%60");
		}
		public void getURL()
		{
			Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);
			Console.WriteLine("Press ENTER to continue...");
			Console.ReadLine();
		}
	}


	class MakeURL
	{
		static void Main(string[] args)
		{
			string projectName;
			bool validP = false;
			string activityName;
			bool validA = false;
			string willContinue = "y";
			Console.WriteLine("Welcome to the URL Encoder!");
			while (willContinue == "y" || willContinue == "Y")
			{
				Console.WriteLine("What is the Project Name?");
				projectName = Console.ReadLine();
				validP = false;
				while (validP == false)
				{
					for (int count = 0; count < projectName.Length; count++)
					{
						if (projectName[count] <= (char)1F & projectName[count] >= (char)00)
						{
							Console.WriteLine("Input Invalid! Please do not use any control characters and input a new Project Name: ");
							projectName = Console.ReadLine();
						}
						else
						{
							if (projectName[count] == (char)7F)
							{
								Console.WriteLine("Input Invalid! Please do not use any control characters and input a new Project Name: ");
								projectName = Console.ReadLine();
							}
							else
							{
								if (count == projectName.Length - 1)
								{
									validP = true;
								}
							}
						}
					}
				}
				Console.WriteLine("What is the Activity Name?");
				activityName = Console.ReadLine();
				validA = false;
				while (validA == false)
				{
					for (int count = 0; count < activityName.Length; count++)
					{
						if (activityName[count] <= (char)1F & activityName[count] >= (char)00)
						{
							Console.WriteLine("Input Invalid! Please do not use any control characters and input a new Activity Name: ");
							activityName = Console.ReadLine();
							break;
						}
						else
						{
							if (activityName[count] == (char)7F)
							{
								Console.WriteLine("Input Invalid! Please do not use any control characters and input a new Activity Name: ");
								activityName = Console.ReadLine();
								break;
							}
							else
							{
								if (count == activityName.Length - 1)
								{
									validA = true;
								}
							}
						}
					}
				}
				ClassURL newURL = new ClassURL(projectName, activityName);
				newURL.fixURL();
				newURL.getURL();
				Console.WriteLine("Would you like to create another URL?(enter 'y' or 'Y' if yes)");
				willContinue = Console.ReadLine();
			}
		}
	}
}
