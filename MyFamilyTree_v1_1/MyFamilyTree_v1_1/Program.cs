using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MyFamilyTree_v1_1
{
	static class Program
	{
		static public List<Person> people = new List<Person>();

		static private void uploadTree()
		{
			Person dummyPerson = new Person();
			people.Add(dummyPerson);
			string line;
			int curPerson = 0;
			StreamReader namesFile = new StreamReader(Application.StartupPath.ToString() + "\\first names.txt");
			StreamReader surnamesFile = new StreamReader(Application.StartupPath.ToString() + "\\last names.txt");
			while ((line = namesFile.ReadLine()) != null)
			{
				curPerson++;
				// Tokenize by tab
				string[] tokens = line.Split('\t');
				Person loadedPerson = new Person();
				loadedPerson.name = tokens[0];
				loadedPerson.fatherIndex = int.Parse(tokens[1]);
				loadedPerson.motherIndex = int.Parse(tokens[2]);
				if (tokens[1] == "0")
				{
					// This person is an ancestor
					loadedPerson.fatherName = surnamesFile.ReadLine();
				}
				else if(tokens[1] == tokens[2])
				{
					// This person has a special civil registration
					loadedPerson.fatherName = people[loadedPerson.fatherIndex].fatherName;
					loadedPerson.motherName = people[loadedPerson.motherIndex].motherName;
					people[loadedPerson.fatherIndex].addChild(curPerson);
				}
				else
				{
					loadedPerson.fatherName = people[loadedPerson.fatherIndex].fatherName;
					loadedPerson.motherName = people[loadedPerson.motherIndex].fatherName;
					people[loadedPerson.fatherIndex].addChild(curPerson);
					people[loadedPerson.motherIndex].addChild(curPerson);
				}
				loadedPerson.gender = char.Parse(tokens[3]);
				loadedPerson.birthdate = DateTime.Parse(tokens[4]);
				loadedPerson.birthPlace = int.Parse(tokens[5]);
				loadedPerson.birthCountry = int.Parse(tokens[6]);
				loadedPerson.deathdate = DateTime.Parse(tokens[7]);
				loadedPerson.deathPlace = int.Parse(tokens[8]);
				loadedPerson.deathCountry = int.Parse(tokens[9]);
				loadedPerson.placeResidence = int.Parse(tokens[10]);
				loadedPerson.countryResidence = int.Parse(tokens[11]);
				loadedPerson.organization = int.Parse(tokens[12]);
				loadedPerson.position = int.Parse(tokens[13]);
				loadedPerson.university = int.Parse(tokens[14]);
				loadedPerson.career = int.Parse(tokens[15]);
				loadedPerson.classOf = int.Parse(tokens[16]);
				people.Add(loadedPerson);
			}
			namesFile.Close();
			surnamesFile.Close();
		}

		static private void Save()
		{
			StreamWriter sw = new StreamWriter(Application.StartupPath + "\\first names.txt");
			string info;
			int curPerson;
			Person p = new Person();
			int population = people.Count - 1;
			for(curPerson = 1; curPerson <= population; curPerson++)
			{
				p = people[curPerson];
				info = p.name + '\t' + p.fatherIndex.ToString() + '\t' + p.motherIndex.ToString() + '\t' + p.gender + '\t'
					+ p.birthdate.ToShortDateString() + '\t' + p.birthPlace.ToString() + '\t'
					+ p.birthCountry.ToString() + '\t' + p.deathdate.ToShortDateString() + '\t'
					+ p.deathPlace.ToString() + '\t' + p.deathCountry.ToString() + '\t'
					+ p.placeResidence.ToString() + '\t' + p.countryResidence.ToString() + '\t'
					+ p.organization.ToString() + '\t' + p.position.ToString() + '\t' + p.university.ToString() + '\t'
					+ p.career.ToString() + '\t' + p.classOf.ToString();
				if (curPerson == population)
				{
					sw.Write(info);
				}
				else
				{
					sw.WriteLine(info);
				}
			}
			sw.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Download the information, and pass it to Form4 and Form1
			uploadTree();
			Form4 logInForm = new Form4(ref people);
			Application.Run(logInForm);
			if (Form4.loginIndex != 0)
			{
				Application.Run(new Form1(ref people, Form4.loginIndex));
			}
			Save();
		}
	}
}
