using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamilyTree_v1_1
{
	public class Person
	{
		public string name { get; set; }
		public string fatherName { get; set; }
		public string motherName { get; set; }
		public int fatherIndex { get; set; }
		public int motherIndex { get; set; }
		public char gender { get; set; }
		public List<int> children = new List<int>();

		public DateTime birthdate { get; set; }
		public int birthPlace { get; set; }
		public int birthCountry { get; set; }
		public DateTime deathdate { get; set; }
		public int deathPlace { get; set; }
		public int deathCountry { get; set; }

		public int countryResidence { get; set; }
		public int placeResidence { get; set; }

		public int university { get; set; }
		public int career { get; set; }
		public int classOf { get; set; }

		public int organization { get; set; }
		public int position { get; set; }

		public Person()
		{
			name = "Unknown";
			fatherName = "Unknown";
			motherName = "Unknown";
			fatherIndex = 0;
			motherIndex = 0;
			gender = 'M';

			birthdate = DateTime.Parse("09/09/1900");
			deathdate = birthdate;
			birthCountry = -1;
			birthPlace = -1;
			deathCountry = -1;
			deathPlace = -1;

			countryResidence = -1;
			placeResidence = -1;

			university = -1;
			career = -1;
			classOf = -1;

			organization = -1;
			position = -1;
		}

		/* isAncestor
		 * 
		 * Determines if this person is an ancestor
		 * 
		 * Paramerers:
		 *	void
		 * Returns:
		 *	bool	Whether this person is an ancestor or not
		 */
		public bool isAncestor()
		{
			return (fatherIndex == 0);
		}

		public string getFullName()
		{
			string fullName = name + " " + fatherName;
			if (!isAncestor())
			{
				fullName += (" " + motherName);
			}
			return fullName;
		}

		public string getBrokenName()
		{
			string brokenName = name + "\r\n" + fatherName;
			if (!isAncestor())
			{
				brokenName += (" " + motherName);
			}
			return brokenName;
		}

		/* addChild
		 * 
		 * Adds a new pointer to a new child for this person
		 * 
		 * Parameters:
		 *	int index	Index of the child in the population array
		 * Returns:
		 *	void
		 */
		public void addChild(int index)
		{
			children.Add(index);
		}

		// More methods are to be added here !!!
	}
}
