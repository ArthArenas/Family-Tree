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
	public partial class Form4 : Form
	{
		public List<Person> people;
		static public int loginIndex;

		public Form4()
		{
			InitializeComponent();
		}

		public Form4(ref List<Person> people)
		{
			InitializeComponent();
			this.people = people;
			loginIndex = 0;
		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			// Here we'll have what is going to happen when you log into the application
			labelFeedback.Text = "";
			for(int i = 1; i < people.Count; i++)
			{
				if(tbFullName.Text.ToUpper() == people[i].getFullName().ToUpper())
				{
					loginIndex = i;
					Close();
					return;
				}
			}
			labelFeedback.Text = "Sorry, we didn't find you";
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			labelFeedback.Text = "";
		}
	}
}
