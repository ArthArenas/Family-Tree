namespace MyFamilyTree_v1_1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pbFather = new System.Windows.Forms.PictureBox();
			this.pbMother = new System.Windows.Forms.PictureBox();
			this.labelFather = new System.Windows.Forms.Label();
			this.labelMother = new System.Windows.Forms.Label();
			this.pbMe = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.btnAddChild = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelMotherName = new System.Windows.Forms.Label();
			this.labelFatherName = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnAddParents = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbFather)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMother)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMe)).BeginInit();
			this.SuspendLayout();
			// 
			// pbFather
			// 
			this.pbFather.BackColor = System.Drawing.SystemColors.Control;
			this.pbFather.Location = new System.Drawing.Point(214, 227);
			this.pbFather.Name = "pbFather";
			this.pbFather.Size = new System.Drawing.Size(153, 179);
			this.pbFather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFather.TabIndex = 0;
			this.pbFather.TabStop = false;
			this.pbFather.Click += new System.EventHandler(this.pbFather_Click);
			// 
			// pbMother
			// 
			this.pbMother.BackColor = System.Drawing.SystemColors.Control;
			this.pbMother.Location = new System.Drawing.Point(696, 227);
			this.pbMother.Name = "pbMother";
			this.pbMother.Size = new System.Drawing.Size(153, 179);
			this.pbMother.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMother.TabIndex = 1;
			this.pbMother.TabStop = false;
			this.pbMother.Click += new System.EventHandler(this.pbMother_Click);
			// 
			// labelFather
			// 
			this.labelFather.AutoSize = true;
			this.labelFather.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFather.Location = new System.Drawing.Point(228, 8);
			this.labelFather.Name = "labelFather";
			this.labelFather.Size = new System.Drawing.Size(157, 26);
			this.labelFather.TabIndex = 2;
			this.labelFather.Text = "Paternal Family:";
			// 
			// labelMother
			// 
			this.labelMother.AutoSize = true;
			this.labelMother.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMother.Location = new System.Drawing.Point(681, 8);
			this.labelMother.Name = "labelMother";
			this.labelMother.Size = new System.Drawing.Size(163, 26);
			this.labelMother.TabIndex = 3;
			this.labelMother.Text = "Maternal Family:";
			// 
			// pbMe
			// 
			this.pbMe.BackColor = System.Drawing.SystemColors.Control;
			this.pbMe.Location = new System.Drawing.Point(406, 459);
			this.pbMe.Name = "pbMe";
			this.pbMe.Size = new System.Drawing.Size(248, 264);
			this.pbMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMe.TabIndex = 4;
			this.pbMe.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.BackColor = System.Drawing.Color.Transparent;
			this.labelName.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.ForeColor = System.Drawing.Color.Black;
			this.labelName.Location = new System.Drawing.Point(529, 749);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(162, 45);
			this.labelName.TabIndex = 7;
			this.labelName.Text = "Full Name";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelName.Click += new System.EventHandler(this.labelName_Click);
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(12, 962);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(35, 13);
			this.labelOutput.TabIndex = 8;
			this.labelOutput.Text = "label1";
			// 
			// btnAddChild
			// 
			this.btnAddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddChild.Location = new System.Drawing.Point(796, 630);
			this.btnAddChild.Name = "btnAddChild";
			this.btnAddChild.Size = new System.Drawing.Size(93, 79);
			this.btnAddChild.TabIndex = 9;
			this.btnAddChild.Text = "Add Child";
			this.btnAddChild.UseVisualStyleBackColor = true;
			this.btnAddChild.Click += new System.EventHandler(this.btnAddMember_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(796, 536);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 79);
			this.button1.TabIndex = 11;
			this.button1.Text = "See Profile";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.06504F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.93496F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 34);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 187);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// labelMotherName
			// 
			this.labelMotherName.AutoSize = true;
			this.labelMotherName.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMotherName.Location = new System.Drawing.Point(775, 406);
			this.labelMotherName.Name = "labelMotherName";
			this.labelMotherName.Size = new System.Drawing.Size(134, 22);
			this.labelMotherName.TabIndex = 13;
			this.labelMotherName.Text = "labelMotherName";
			this.labelMotherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelFatherName
			// 
			this.labelFatherName.AutoSize = true;
			this.labelFatherName.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFatherName.Location = new System.Drawing.Point(290, 409);
			this.labelFatherName.Name = "labelFatherName";
			this.labelFatherName.Size = new System.Drawing.Size(129, 22);
			this.labelFatherName.TabIndex = 14;
			this.labelFatherName.Text = "labelFatherName";
			this.labelFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(518, 844);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
			this.flowLayoutPanel1.TabIndex = 15;
			// 
			// btnAddParents
			// 
			this.btnAddParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddParents.Location = new System.Drawing.Point(908, 536);
			this.btnAddParents.Name = "btnAddParents";
			this.btnAddParents.Size = new System.Drawing.Size(85, 172);
			this.btnAddParents.TabIndex = 16;
			this.btnAddParents.Text = "Add Parents";
			this.btnAddParents.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(1032, 984);
			this.Controls.Add(this.btnAddParents);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.labelFatherName);
			this.Controls.Add(this.labelMotherName);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAddChild);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.pbMe);
			this.Controls.Add(this.labelMother);
			this.Controls.Add(this.labelFather);
			this.Controls.Add(this.pbMother);
			this.Controls.Add(this.pbFather);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbFather)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMother)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbFather;
		private System.Windows.Forms.PictureBox pbMother;
		private System.Windows.Forms.Label labelFather;
		private System.Windows.Forms.Label labelMother;
		private System.Windows.Forms.PictureBox pbMe;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.Button btnAddChild;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelMotherName;
		private System.Windows.Forms.Label labelFatherName;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnAddParents;
	}
}

