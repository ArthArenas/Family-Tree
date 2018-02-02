using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MyFamilyTree_v1_1
{
	public partial class Form3 : Form
	{
		Person profiler;
		List<string> careers = new List<string>();
		List<string> countries = new List<string>();
		List<string> organizations = new List<string>();
		List<string> places = new List<string>();
		List<string> positions = new List<string>();
		List<string> universities = new List<string>();
		List<HistoricalEvent> historicalEvents = new List<HistoricalEvent>();

		public Form3()
		{
			InitializeComponent();
		}

		public Form3(Person p)
		{
			InitializeComponent();
			profiler = p;
		}

		private string getPicturePath(string name)
		{
			char gender = profiler.gender;
			string photosPath = Application.StartupPath + "\\Photos\\";
			string defaultPath = (gender == 'M') ? photosPath + "Default_Man.jpg" : photosPath + "Default_Woman.jpg";
			string picturePath = photosPath + name + ".jpg";
			return (File.Exists(picturePath)) ? picturePath : defaultPath;
		}

		private string getPlace(int city, int country)
		{
			string place;
			if (country == -1)
			{
				place = "Unknown";
			}
			else
			{
				string countryName = countries[country];
				string cityName = city != -1 ? places[city] : "";
				countryName = (countryName.Length == 5) ? countryName.Substring(0, 3) : countryName;
				place = (city != -1) ? cityName + ", " + countryName : countryName;
			}
			return place;
		}

		private void loadFromFile(ref List<string> myList, string path)
		{
			StreamReader myFile = new StreamReader(path);
			string line;
			while ((line = myFile.ReadLine()) != null)
			{
				myList.Add(line);
			}
			myFile.Close();
		}

		private void loadFromFile(ref List<HistoricalEvent> myList, string path)
		{
			StreamReader myFile = new StreamReader(path);
			string line;
			while ((line = myFile.ReadLine()) != null)
			{
				string[] details = line.Split('\t');
				DateTime start = DateTime.Parse(details[0]);
				DateTime end = new DateTime();
				if(details[1] == "Present")
				{
					end = DateTime.Now;
				}
				else
				{
					end = DateTime.Parse(details[1]);
				}
				string title = details[2];
				HistoricalEvent h = new HistoricalEvent(title, start, end);
				myList.Add(h);
			}
			myFile.Close();
		}

		private void gbCurResidence_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Form3_Load(object sender, EventArgs e)
		{
			// initial setting of the profile
			labelName.Text = profiler.getFullName();
			pbPicture.Image = Image.FromFile(getPicturePath(profiler.getFullName()));
			// upload lists
			string commonPath = Application.StartupPath + "\\";
			loadFromFile(ref careers, commonPath + "Careers.txt");
			loadFromFile(ref countries, commonPath + "Countries.txt");
			loadFromFile(ref organizations, commonPath + "Organizations.txt");
			loadFromFile(ref places, commonPath + "Places.txt");
			loadFromFile(ref positions, commonPath + "Positions.txt");
			loadFromFile(ref universities, commonPath + "Universities.txt");
			loadFromFile(ref historicalEvents, commonPath + "Historical events.txt");

			// Set life and death details
			DateTime unknownDate = new DateTime(1900, 9, 9);
			labelBirthplace.Text = getPlace(profiler.birthPlace, profiler.birthCountry);
			if (profiler.birthdate == unknownDate)
			{
				labelBirthdate.Text = "Birth: Unknown";
			}
			else
			{
				labelBirthdate.Text = (profiler.birthdate.Day == 1 && profiler.birthdate.Month == 1 && profiler.birthdate.Year < 1970) ? 
					"Birth: " + profiler.birthdate.Year.ToString() : 
					"Birth: " + profiler.birthdate.ToLongDateString();
			}
			if(profiler.deathPlace == -2)
			{
				// Person is alive
				labelDeathdate.Visible = false;
				labelDeathplace.Visible = false;
			}
			else
			{
				labelDeathplace.Text = getPlace(profiler.deathPlace, profiler.deathCountry);
				labelDeathdate.Text = profiler.deathdate == unknownDate ? "Death: Unknown" : "Death: " + profiler.deathdate.ToLongDateString();
			}

			// set residence
			if(profiler.deathPlace == -2)
			{
				// Person is alive
				labelResidence.Text = getPlace(profiler.placeResidence, profiler.countryResidence);
				if (profiler.countryResidence == -1)
				{
					pbResidence.Visible = false;
				}
				else
				{
					pbResidence.Image = Image.FromFile(getPicturePath(countries[profiler.countryResidence]));
				}
			}
			else
			{
				// Person is dead, take the birth information
				gbCurResidence.Text = "Birth place";
				labelResidence.Text = getPlace(profiler.birthPlace, profiler.birthCountry);
				if(profiler.birthCountry == -1)
				{
					pbResidence.Visible = false;
					pbResidence.Enabled = false;
				}
				else
				{
					pbResidence.Image = Image.FromFile(getPicturePath(countries[profiler.birthCountry]));
				}
			}

			// Set work
			labelOrganization.Text = (profiler.organization == -1) ? "" : organizations[profiler.organization];
			labelPosition.Text = (profiler.position == -1) ? "" : positions[profiler.position];
			if (profiler.organization != -1 && File.Exists(getPicturePath(organizations[profiler.organization])))
			{
				pbWork.Image = Image.FromFile(getPicturePath(organizations[profiler.organization]));
			}

			// Set education
			labelUniversity.Text = (profiler.university == -1) ? "" : universities[profiler.university];
			labelCareer.Text = (profiler.career == -1) ? "" : careers[profiler.career];
			if(profiler.classOf > -1)
			{
				labelCareer.Text += (" | Class of " + profiler.classOf.ToString());
			}
			if(profiler.career != -1 && File.Exists(getPicturePath(universities[profiler.university])))
			{
				pbEducation.Image = Image.FromFile(getPicturePath(universities[profiler.university]));
			}

			// Set historical events
			if(profiler.birthdate != unknownDate)
			{
				DateTime birth = profiler.birthdate;
				DateTime death = new DateTime();
				if(profiler.deathdate == unknownDate)
				{
					death = birth.AddYears(65);
				}
				else
				{
					death = profiler.deathdate;
				}
				foreach (HistoricalEvent h in historicalEvents)
				{
					if(!(death < h.start || birth > h.end))
					{
						lbHistoricalEvents.Items.Add(h.title + " (" + h.start.Year + " - " + h.end.Year + ")");
					}
				}
			}
		}
	}
}
