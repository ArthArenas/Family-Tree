using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFamilyTree_v1_1
{
	public partial class Form2 : Form
	{
		static private List<Person> people = new List<Person>();
		private int curIndex { get; set; }

		public Form2()
		{
			InitializeComponent();
		}

		public Form2(ref List<Person> people, int curIndex)
		{
			InitializeComponent();
			Form2.people = people;
			this.curIndex = curIndex;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			//
		}

		private int myFind(string name)
		{
			for(int i = 1; i < people.Count; i++)
			{
				if(people[i].getFullName() == name)
				{
					labelError.Text += i.ToString() + " ";
					return i;
				}
			}
			labelError.Text += "0 ";
			return 0;
		}

		private void btnAddMember_Click(object sender, EventArgs e)
		{
			// Validate all the information
			labelError.Text = "Hello";
			if(cbGender.SelectedIndex == -1)
			{
				labelError.Visible = true;
				labelError.Text = "Gender unspecified";
				return;
			}
			/*
			try
			{
				DateTime testDate = DateTime.Parse(tbBirthdate.Text);
				testDate = DateTime.Parse(tbDeathdate.Text);
			}
			catch
			{
				labelError.Visible = true;
				labelError.Text = "Birth and/or Death dates format are wrong";
				return;
			}
			*/
			if (tbGivenName.Text == "" || tbFatherName.Text == "" || tbMotherName.Text == "")
			{
				labelError.Visible = true;
				labelError.Text = "Missing names";
				return;
			}
			int fatherIndex = myFind(tbFatherName.Text);
			int motherIndex = myFind(tbMotherName.Text);
			if(fatherIndex == 0 || motherIndex == 0)
			{
				labelError.Visible = true;
				labelError.Text += "Names of parents are wrong";
				return;
			}
			string name = tbGivenName.Text;
			char gender = (cbGender.SelectedIndex == 0) ? 'M' : 'F';
			Person q = new Person();
			q.name = name;
			q.fatherIndex = fatherIndex;
			q.motherIndex = motherIndex;
			q.gender = gender;
			people.Add(q);
			if(fatherIndex == motherIndex)
			{
				people[fatherIndex].addChild(people.Count - 1);
			}
			else
			{
				people[fatherIndex].addChild(people.Count - 1);
				people[motherIndex].addChild(people.Count - 1);
			}
			Program.people = people;
		}
	}
}
