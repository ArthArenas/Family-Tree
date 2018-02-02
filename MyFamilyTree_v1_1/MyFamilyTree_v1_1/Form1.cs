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
	public partial class Form1 : Form
	{
		// MEMBERS
		private List<Person> people = new List<Person>();
		private int curIndex;

		public Form1()
		{
			InitializeComponent();
		}

		public Form1(ref List<Person> people, int curIndex)
		{
			InitializeComponent();
			this.people = people;
			this.curIndex = curIndex;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// uploadTree();
			// curIndex = 12;
			displayPerson();
		}

		private void displayPerson()
		{
			flowLayoutPanel1.Controls.Clear();
			tableLayoutPanel1.Controls.Clear();
			bool isAncestor = people[curIndex].isAncestor();
			bool hasChildren = (people[curIndex].children.Count != 0);
			// father's and mother's picture
			if (isAncestor)
			{
				labelFather.Visible = false; labelFather.Enabled = false;
				labelMother.Visible = false; labelMother.Enabled = false;
				pbFather.Visible = false; pbFather.Enabled = false;
				pbMother.Visible = false; pbMother.Enabled = false;
				labelFatherName.Visible = false; labelFatherName.Enabled = false;
				labelMotherName.Visible = false; labelMotherName.Enabled = false;
			}
			else
			{
				labelFather.Visible = true; labelFather.Enabled = true;
				labelMother.Visible = true; labelMother.Enabled = true;
				pbFather.Visible = true; pbFather.Enabled = true;
				pbMother.Visible = true; pbMother.Enabled = true;
				labelFatherName.Visible = true; labelFatherName.Enabled = true;
				labelMotherName.Visible = true; labelMotherName.Enabled = true;
				string fatherPicturePath = getPicturePath(people[curIndex].fatherIndex);
				string motherPicturePath = getPicturePath(people[curIndex].motherIndex);
				pbFather.Image = Image.FromFile(fatherPicturePath);
				pbMother.Image = Image.FromFile(motherPicturePath);
				labelFatherName.Text = people[people[curIndex].fatherIndex].getBrokenName();
				labelMotherName.Text = people[people[curIndex].motherIndex].getBrokenName();
				Point newLabelAnchorF = new Point(290 - labelFatherName.Size.Width/2, 410);
				Point newLabelAnchorM = new Point(775 - labelMotherName.Size.Width/2, 410);
				labelFatherName.Location = newLabelAnchorF;
				labelMotherName.Location = newLabelAnchorM;
			}
			// me picture
			string myPicturePath = getPicturePath(curIndex);
			pbMe.Image = Image.FromFile(myPicturePath);
			labelName.Text = people[curIndex].getBrokenName();
			Point newAnchor = new Point(530 - labelName.Size.Width / 2, 730);
			labelName.Location = newAnchor;
			// children pictures
			if (hasChildren)
			{
				flowLayoutPanel1.Visible = true;
				int children = people[curIndex].children.Count;
				foreach (int i in people[curIndex].children)
				{
					PictureBox pbChild = new PictureBox();
					pbChild.Tag = i;
					pbChild.Image = Image.FromFile(getPicturePath(i));
					pbChild.Height = 120;
					pbChild.SizeMode = PictureBoxSizeMode.Zoom;
					pbChild.Click += childPictureBox_Click;
					flowLayoutPanel1.Controls.Add(pbChild);
				}
				// flowLayoutPanel1.Height = 124;
				Point flpAnchor = new Point(530 - flowLayoutPanel1.Size.Width / 2, flowLayoutPanel1.Location.Y);
				flowLayoutPanel1.Location = flpAnchor;
			}
			else
			{
				flowLayoutPanel1.Visible = false;
			}

			// grandparents
			int[] grandparents = getGrandparents();
			for(int i = 0; i < 4; i++)
			{
				if(grandparents[i] != -1)
				{
					// Have the name for now
					PictureBox grandparentPhoto = new PictureBox();
					grandparentPhoto.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
					grandparentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
					grandparentPhoto.Image = Image.FromFile(getPicturePath(grandparents[i]));
					Label grandparentName = new Label();
					grandparentName.Text = people[grandparents[i]].getBrokenName();
					grandparentName.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
					grandparentName.TextAlign = ContentAlignment.MiddleCenter;
					grandparentName.Font = labelFatherName.Font;
					tableLayoutPanel1.Controls.Add(grandparentPhoto, 2 * i, 0);
					tableLayoutPanel1.Controls.Add(grandparentName, 2 * i, 1);
				}
			}
		}

		private string getPicturePath(int index)
		{
			string name = people[index].getFullName();
			char gender = people[index].gender;
			string photosPath = Application.StartupPath + "\\Photos\\";
			string defaultPath = (gender == 'M') ? photosPath + "Default_Man.jpg" : photosPath + "Default_Woman.jpg";
			string picturePath = photosPath + name + ".jpg";
			return (File.Exists(picturePath)) ?  picturePath : defaultPath;
		}

		private int[] getGrandparents()
		{
			int[] grandparents = new int[] { -1, -1, -1, -1 };
			if (!people[curIndex].isAncestor())
			{
				int father = people[curIndex].fatherIndex;
				int mother = people[curIndex].motherIndex;
				if(!people[father].isAncestor())
				{
					grandparents[0] = people[father].fatherIndex;
					grandparents[1] = people[father].motherIndex;
				}
				if (!people[mother].isAncestor())
				{
					grandparents[2] = people[mother].fatherIndex;
					grandparents[3] = people[mother].motherIndex;
				}
			} 
			return grandparents;
		}

		private void pbFather_Click(object sender, EventArgs e)
		{
			curIndex = people[curIndex].fatherIndex;
			displayPerson();
		}

		private void pbMother_Click(object sender, EventArgs e)
		{
			curIndex = people[curIndex].motherIndex;
			displayPerson();
		}

		private void btnAddMember_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2(ref people, curIndex);
			f2.Show();
		}

		private void labelName_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3(people[curIndex]);
			f3.Show();
		}

		private void childPictureBox_Click(object sender, EventArgs e)
		{
			if(sender is PictureBox)
			{
				PictureBox pbSelected = new PictureBox();
				pbSelected = sender as PictureBox;
				if(pbSelected.Tag is int)
				{
					int taggedIndex = Convert.ToInt32(pbSelected.Tag);
					curIndex = taggedIndex;
				}
			}
			displayPerson();
		}
	}
}
